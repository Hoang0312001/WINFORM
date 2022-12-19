using ManagerFoodGUI.DTO;
using ManagerFoodGUI.mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerFoodGUI.service
{
    internal class TableService
    {
        public static List<TableDTO> getAll()
        {
            List<TableDTO> list = new List<TableDTO>(); 
            using (ManagerFoodEntities entities = new ManagerFoodEntities())
            {
                var listEntity = (from t in entities.TableFoods select t).ToList();
                foreach(var entity in listEntity)
                {
                    TableDTO tableDTO = TableMapper.toDTO(entity);
                    list.Add(tableDTO);
                }
            }
            return list;
           

        }
        public static int ChechStatus(int idTable)
        {
            using(ManagerFoodEntities entities = new ManagerFoodEntities())
            {
                var sta = (from s in entities.TableFoods
                           where s.id == idTable
                           select new {s}).FirstOrDefault();
               if(sta != null)
                {
                    return 1;
                }
               return 0;
            }
        }
    }
}
