using ManagerFoodGUI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerFoodGUI.mapper
{
    internal class CategoryMapper
    {
        public static CategoryDTO toDTO(CategoryFood categoryFood)
        {
            CategoryDTO categoryDTO = new CategoryDTO();
            categoryDTO.Id = categoryFood.id;
            categoryDTO.Name = categoryFood.name;
            return categoryDTO;

        }
    }
}
