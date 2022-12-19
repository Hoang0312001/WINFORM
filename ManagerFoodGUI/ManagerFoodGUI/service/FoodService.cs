using ManagerFoodGUI.DTO;
using ManagerFoodGUI.mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerFoodGUI.service
{
    internal class FoodService
    {
        public static List<FoodDTO> GetAll()
        {
            List<FoodDTO> list = new List<FoodDTO>();
            using (ManagerFoodEntities entities = new ManagerFoodEntities())
            {
                var listEntity = (from e in entities.Foods select e).ToList();
                foreach (var foods in listEntity)
                {

                    FoodDTO foodDTO = FoodMapper.toDTO(foods);
                    list.Add(foodDTO);
                }
            }
            return list;
        }
        public static List<FoodDTO> FindByIdCategory(int idCategory)
        {
            List<FoodDTO> list = new List<FoodDTO>();
            using (ManagerFoodEntities entities = new ManagerFoodEntities())
            {
                var listEntity = (from e in entities.Foods where e.idCategory == idCategory select e).ToList();
                foreach (var foods in listEntity)
                {

                    FoodDTO foodDTO = FoodMapper.toDTO(foods);
                    list.Add(foodDTO);
                }
            }
            return list;
        }
    }
}
