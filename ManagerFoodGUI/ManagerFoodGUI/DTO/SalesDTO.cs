using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerFoodGUI.DTO
{
    internal class SalesDTO
    {
        private DateTime time;
        private float totalPrice;

        public DateTime Time { get => time; set => time = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
