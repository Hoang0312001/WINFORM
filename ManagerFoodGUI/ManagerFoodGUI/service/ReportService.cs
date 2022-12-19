using ManagerFoodGUI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerFoodGUI.service
{
    internal class ReportService
    {
        public static List<RpBillDTO> FindAll(int idBill)
        {
            List<RpBillDTO> list = new List<RpBillDTO>();
            using(ManagerFoodEntities entities= new ManagerFoodEntities())
            {
                var entity = (from e in entities.BillInfoes
                              join f in entities.Foods on e.idFood equals f.id
                              where e.idBill == idBill
                              select new
                              {
                                  Name =  f.name,
                                  Price = f.price,
                                  Count = e.count,
                                  TotalPrice = f.price*e.count
                              }
                              ).ToList();
                foreach(var e in entity)
                {
                    RpBillDTO rpBillDTO = new RpBillDTO();
                    rpBillDTO.Name = e.Name;
                    rpBillDTO.Price = e.Price;
                    rpBillDTO.Count = e.Count;
                    rpBillDTO.TotalPice = e.TotalPrice;
                    list.Add(rpBillDTO);
                }
            }
            return list;
        }
    }
}
