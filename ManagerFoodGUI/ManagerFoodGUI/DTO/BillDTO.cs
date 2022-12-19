using ManagerFoodGUI.service.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerFoodGUI.DTO
{
    internal class BillDTO
    {
        private int id;
        private System.DateTime dateCheckIn;
        private Nullable<System.DateTime> dateCheckOut;
        private int idTable;
        private int status;
        private TableDTO TableDTOl;
        public BillDTO() { }
        public BillDTO(DateTime dateCheckOut,int idTable,int status)
        {
            this.dateCheckOut = dateCheckOut;
            this.idTable = idTable;
            this.status = status;
        }
        public BillDTO(DateTime dateCheckOut, int idTable)
        {
            this.dateCheckOut = dateCheckOut;
            this.idTable = idTable;
     
        }
        public int Id { get => id; set => id = value; }
        public DateTime DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public int IdTable { get => idTable; set => idTable = value; }
        public int Status { get => status; set => status = value; }
        internal TableDTO TableDTOl1 { get => TableDTOl; set => TableDTOl = value; }
    }
}
