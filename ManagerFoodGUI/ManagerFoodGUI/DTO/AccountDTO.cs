using Microsoft.VisualStudio.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerFoodGUI.DTO
{
    internal class AccountDTO
    {

        [StringLength(50, MinimumLength = 3, ErrorMessage = "userName từ 3 đến  100 ký tự")]
        private string userName;
        [StringLength(1000, MinimumLength = 3, ErrorMessage = "passWord từ 3 đến  1000 ký tự")]
        private string passWord;
        [StringLength(100, MinimumLength = 3, ErrorMessage = "fullName từ 3 đến  100 ký tự")]
        private string fullName;
        private int status;
        private int type;
        public AccountDTO(string userName,string passWord ,string fullName , int status , int type)
        {
            this.userName = userName;
            this.passWord = passWord;
            this.fullName = fullName;
            this.status = status;
            this.type = type;

        }
        public AccountDTO() { }
        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public int Status { get => status; set => status = value; }
        public int Type { get => type; set => type = value; }
        /*      Singleton*/
        /*   public static DataProvider instance;
           public static DataProvider Instance
           {
               get{ return AccountDTO.instance; }
               set { AccountDTO.instance = value; }
           }*/
    }
}
