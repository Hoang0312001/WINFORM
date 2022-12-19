using ManagerFoodGUI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerFoodGUI.mapper
{
    internal class BillInforMapper
    {
        public static BillInforDTO ToDTO(BillInfo billInfo)
        {
            BillInforDTO billInforDTO = new BillInforDTO();
            billInforDTO.Id = billInfo.id;
            billInforDTO.Count = billInfo.count;
            billInforDTO.FoodDTO1 = FoodMapper.toDTO(billInfo.Food);
            billInforDTO.BillDTO1 = BillMapper.toDTO(billInfo.Bill);
            return billInforDTO;


        }                                                                                                           
        public static BillInfo toEntity(BillInforDTO billInforDTO)
        {
            BillInfo billInfo = new BillInfo();
            billInfo.idBill = billInforDTO.IdBill;
         /*   billInfo.Bill = BillMapper.toEntity(billInforDTO.BillDTO1);*/
            billInfo.idFood = billInforDTO.IdFood;
            billInfo.count= billInforDTO.Count;
            
            return billInfo;
        }
        
    }
}
