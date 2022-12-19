using ManagerFoodGUI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerFoodGUI.mapper
{
     class AccountMapper
    {
        public static AccountDTO toDTO(Account account)
        {
            AccountDTO accountDTO = new AccountDTO();
            accountDTO.UserName = account.userName;
            accountDTO.FullName = account.fullName;
            accountDTO.PassWord = account.passWord;
            accountDTO.Status = account.status;
            accountDTO.Type= account.type;

            return accountDTO;
        } 
        public static Account fromEntity(AccountDTO accountDTO)
        {
            Account account = new Account();
            
            account.userName = accountDTO.UserName;
            account.fullName = accountDTO.FullName;
            account.passWord = accountDTO.PassWord;
            account.status = accountDTO.Status;
            account.type = accountDTO.Type;
            return account;

        }
    }
}
