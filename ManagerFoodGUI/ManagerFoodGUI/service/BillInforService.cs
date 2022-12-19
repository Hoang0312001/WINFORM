using ManagerFoodGUI.DTO;
using ManagerFoodGUI.mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerFoodGUI.service
{
    internal class BillInforService
    {
        public static List<BillInforDTO> getAllInnerFoodAndBill(int idTable)
        {
            List<BillInforDTO> list = new List<BillInforDTO>();
            using (ManagerFoodEntities entityManager = new ManagerFoodEntities())
            {

                var listEnity = (from billInfo in entityManager.BillInfoes
                                 join bill in entityManager.Bills on billInfo.idBill equals bill.id
                                 join food in entityManager.Foods on billInfo.idFood equals food.id
                                 where bill.idTable == idTable && bill.status == 1
                                 select billInfo
                                 ).ToList();
                foreach (var item in listEnity)
                {
                    var billInfo = BillInforMapper.ToDTO(item);
                    list.Add(billInfo);
                }

            }
            return list;
        }
        public static void UpdateBilInforCountByIdFoodAndIdBill(BillInforDTO billInforDTO, ManagerFoodEntities entities)
        {

            var food = (from e in entities.BillInfoes
                        where e.idFood == billInforDTO.IdFood && e.idBill == billInforDTO.IdBill
                        select e
                        ).FirstOrDefault();
            if (food != null)
            {
                food.count = food.count + billInforDTO.Count;

            }
            else
            {
                billInforDTO = new BillInforDTO(billInforDTO.IdBill, billInforDTO.IdFood, billInforDTO.Count);
                BillInfo billInfo = BillInforMapper.toEntity(billInforDTO);
                entities.BillInfoes.Add(billInfo);
            }


        }
    }
}
