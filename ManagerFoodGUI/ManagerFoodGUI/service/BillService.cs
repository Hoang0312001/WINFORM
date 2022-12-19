using ManagerFoodGUI.DTO;
using ManagerFoodGUI.mapper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ManagerFoodGUI.service
{
    internal class BillService
    {
        public static int Order(BillDTO billDTO, int idFood, int count)
        {
            int success = 0;
            using (ManagerFoodEntities entities = new ManagerFoodEntities())
            {

                using (DbContextTransaction transaction = entities.Database.BeginTransaction())
                {
                    try
                    {

                        BillInforDTO billInforDTO = null;
                        int idBill = CheckStatusBill(billDTO.IdTable, entities);
                        if (idBill == 0)
                        {
                            Bill bill = BillMapper.toEntity(billDTO);
                            entities.Bills.Add(bill);
                            updateStatusTable(billDTO.IdTable, entities);

                            billInforDTO = new BillInforDTO(bill.id, idFood, count);
                            BillInfo billInfo = BillInforMapper.toEntity(billInforDTO);
                            entities.BillInfoes.Add(billInfo);
                            entities.SaveChanges();
                        }
                        else
                        {
                            billInforDTO = new BillInforDTO(idBill, idFood, count);
                            BillInforService.UpdateBilInforCountByIdFoodAndIdBill(billInforDTO, entities);
                            entities.SaveChanges();
                        }

                        /*
                            BillInfo billInfo = BillInforMapper.toEntity(billInforDTO);

                            entities.BillInfoes.Add(billInfo);
                            success = entities.SaveChanges();*/

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                    }
                }
            }
            return success;
        }




        public static int CheckStatusBill(int idTable, ManagerFoodEntities entities)
        {
            var status = (from sta in entities.Bills
                          where sta.status == 1 && sta.idTable == idTable
                          select new { sta.id }
                              ).FirstOrDefault();
            if (status != null)
            {
                int id = Int32.Parse(status.id.ToString());
                return id;
            }
            return 0;

        }
        public static void updateStatusTable(int idTable, ManagerFoodEntities entities)
        {
            var findIdTable = (from t in entities.TableFoods
                               where t.id == idTable
                               select t)
                               .FirstOrDefault();
            findIdTable.status = 1;
        }
        public static void Checkout(int idTable)
        {
            using (ManagerFoodEntities entities = new ManagerFoodEntities())
            {
                var findBillByTable = (from b in entities.Bills
                                       join t in entities.TableFoods on b.idTable equals t.id
                                       where b.idTable == idTable && b.status == 1
                                       select new { b, t }
                                      ).FirstOrDefault();
                findBillByTable.t.status = 0;
                findBillByTable.b.status = 0;
                findBillByTable.b.dateCheckOut = DateTime.Now;
                entities.SaveChanges();
            }
        }

        public static List<SalesDTO> Sales(DateTime startTime, DateTime endTime)
        {

            List<SalesDTO> list = new List<SalesDTO>();
            using (ManagerFoodEntities entities = new ManagerFoodEntities())
            {
                var entity = (from s in entities.BillInfoes
                              join b in entities.Bills on s.idBill equals b.id
                              join f in entities.Foods on s.idFood equals f.id
                              where (b.dateCheckOut >= startTime && b.dateCheckOut <= endTime)
                              group b by b.dateCheckOut into time
                              orderby time.Key
                              select time
                            );
                foreach (var group in entity)
                {
                    SalesDTO salesDTO = new SalesDTO();
                    salesDTO.Time = (DateTime)group.Key;
                    int totalPrice = 0;
                    foreach (var bill in group)
                    {
                        int prices = 0;
                        bill.BillInfoes.ToList().ForEach(e =>
                        {
                            prices = e.Food.price;
                        });
                        totalPrice += prices;
                    }
                    salesDTO.TotalPrice = totalPrice;
                }

            }
            return list;
        }
    }
}
