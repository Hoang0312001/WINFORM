using ManagerFoodGUI.DTO;
using ManagerFoodGUI.mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerFoodGUI.service
{
    internal class CategoryService
    {
        public static List<CategoryDTO> GetAll()
        {
            List<CategoryDTO> list = new List<CategoryDTO>();
            using(ManagerFoodEntities entities = new ManagerFoodEntities())
            {
                var listEntity = (from e in entities.CategoryFoods select e).ToList();
                foreach(CategoryFood category in listEntity)
                {
                    CategoryDTO categoryDTO = CategoryMapper.toDTO(category);
                    list.Add(categoryDTO);
                }
            }
            return list;
        }
    }
}
