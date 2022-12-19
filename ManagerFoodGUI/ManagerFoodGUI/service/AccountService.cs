using ManagerFoodGUI.DTO;
using ManagerFoodGUI.mapper;
using ManagerFoodGUI.service.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerFoodGUI.service
{
    class AccountService 
    {

      
      
        public static List<AccountDTO> getAll()
        {
            List<AccountDTO> list = new List<AccountDTO>();
            using (ManagerFoodEntities entities = new ManagerFoodEntities())
            {

                var listAccount = (from account in entities.Accounts select account).ToList();
             
                foreach (var account in listAccount)
                {
                    AccountDTO accountDTO = AccountMapper.toDTO(account);
                    list.Add(accountDTO);

                }
            }

            return list;
        }
        public static bool findAccountByUserName(string userName , string passWord)
        {
            using (ManagerFoodEntities list = new ManagerFoodEntities())
            {
                var queryCheckAccount = (from user in list.Accounts
                                         where user.userName == userName
                                         where user.passWord == passWord
                                         select user).Take(1).ToList();
                if(queryCheckAccount.Count == 0)
                {
                  
                    return false;
                }
            }
            return true;
        }
    }
}
