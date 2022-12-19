using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerFoodGUI.DTO
{
    internal class TableDTO
    {
        private int id;
        [StringLength(500, MinimumLength = 3, ErrorMessage = "name từ 3 đến  500 ký tự")]
        private string name;
        [StringLength(500, MinimumLength = 3, ErrorMessage = "inforBook từ 3 đến  500 ký tự")]
        private string inforBook;
        private int status;

        public string Name { get => name; set => name = value; }
        public string InforBook { get => inforBook; set => inforBook = value; }
        public int Status { get => status; set => status = value; }
        public int Id { get => id; set => id = value; }
    }
}
