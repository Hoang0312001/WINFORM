using ManagerFoodGUI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerFoodGUI.mapper
{
    internal class FoodMapper
    {
        public static FoodDTO toDTO(Food food)
        {
            FoodDTO foodDTO = new FoodDTO();
            foodDTO.Id = food.id;
            foodDTO.Name = food.name;
            foodDTO.Price = food.price;
            foodDTO.CategoryFood1 = food.CategoryFood;
            return foodDTO;
        }
    }
}
