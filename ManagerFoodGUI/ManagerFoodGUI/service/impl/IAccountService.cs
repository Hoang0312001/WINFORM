using ManagerFoodGUI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerFoodGUI.service.impl
{
    internal interface IAccountService
    {
        List<AccountDTO> getAll();
    }
}
