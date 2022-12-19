using ManagerFoodGUI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerFoodGUI.mapper
{
    internal class BillMapper
    {
        public static BillDTO toDTO(Bill bill)
        {
            BillDTO billDTO = new BillDTO();
            billDTO.Id = bill.id;
            billDTO.DateCheckIn = bill.dateCheckIn;
            billDTO.DateCheckOut = bill.dateCheckOut;
            billDTO.Status= bill.status;
            billDTO.TableDTOl1 = TableMapper.toDTO(bill.TableFood);

            return billDTO;

        }
        public static Bill toEntity(BillDTO billDTO)
        {
            Bill bill = new Bill();
            bill.dateCheckIn = billDTO.DateCheckIn;
            bill.idTable = billDTO.IdTable;
            bill.status = billDTO.Status;
            return bill;
        }
    }

}
