using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Utilities.Exception;

namespace CinemaProject.Business.ValidationRules
{
    public class UserValidator
    {
        public static void checktValidation(params string[] text)
        {
            foreach (var item in text)
            {
                if (string.IsNullOrWhiteSpace(item) && string.IsNullOrEmpty(item))
                {
                    throw new UserValidatorException("Lütfen boş ya da eksik bırakmayınız");
                }
            }

        }
    }
}
