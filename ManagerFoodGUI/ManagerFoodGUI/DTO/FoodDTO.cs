using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerFoodGUI.DTO
{
    internal class FoodDTO
    {
        private int id;
        private string name;
        private int price;
        private CategoryFood CategoryFood;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public CategoryFood CategoryFood1 { get => CategoryFood; set => CategoryFood = value; }
    }
}
