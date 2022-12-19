using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerFoodGUI.valid
{
    internal class Validations<T>
    {
        public static List<ValidationResult> Check(T t) {
            ValidationContext validation = new ValidationContext(t, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(t, validation, results, true);
            return results;
        }
    }
}
