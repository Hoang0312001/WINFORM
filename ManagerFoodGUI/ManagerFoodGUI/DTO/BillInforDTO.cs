using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerFoodGUI.DTO
{
    internal class BillInforDTO
    {
        private int id;
        private int idFood;
        private int idBill;
        private BillDTO BillDTO;
        private FoodDTO FoodDTO;
        private int count;
        public BillInforDTO(BillDTO billDTO, int idFood, int count)
        {
            this.BillDTO = billDTO;
            this.IdFood = idFood;
            this.count = count;

        }
        public BillInforDTO(int idBill, int idFood, int count)
        {
            this.idBill = idBill;
            this.IdFood = idFood;
            this.count = count;

        }
        public BillInforDTO() { }

        public int Id { get => id; set => id = value; }
        public int Count { get => count; set => count = value; }
        public int IdFood { get => idFood; set => idFood = value; }
        internal BillDTO BillDTO1 { get => BillDTO; set => BillDTO = value; }
        internal FoodDTO FoodDTO1 { get => FoodDTO; set => FoodDTO = value; }
        public int IdBill { get => idBill; set => idBill = value; }
    }
}
