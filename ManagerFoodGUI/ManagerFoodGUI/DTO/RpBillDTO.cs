using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerFoodGUI.DTO
{
    internal class RpBillDTO
    {
        private string name;
        private int price;
        private int count;
        private int totalPice;
        private int totalAllPrice;

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public int Count { get => count; set => count = value; }
        public int TotalPice { get => totalPice; set => totalPice = value; }
        public int TotalAllPrice { get => totalAllPrice; set => totalAllPrice = value; }
    }
}
