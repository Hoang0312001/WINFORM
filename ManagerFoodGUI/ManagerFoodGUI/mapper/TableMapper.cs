using ManagerFoodGUI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerFoodGUI.mapper
{
    internal class TableMapper
    {
        public static TableDTO toDTO(TableFood tableFood)
        {
            TableDTO tableDTO = new TableDTO();
            tableDTO.Id = tableFood.id;
            tableDTO.Name = tableFood.name;
            tableDTO.InforBook = tableFood.inforBook;
            tableDTO.Status = tableFood.status;
           
            return tableDTO;
        }
        public static TableFood fromEntity(TableDTO tableDTO)
        {
            TableFood tableFood = new TableFood();
            tableFood.id = tableDTO.Id;
            tableFood.name = tableDTO.Name;
            tableFood.inforBook = tableDTO.InforBook;
            tableFood.status = tableDTO.Status;

         
            return tableFood;

        }
    }
}
