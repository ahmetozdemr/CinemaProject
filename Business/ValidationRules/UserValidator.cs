using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.Business.ValidationRules
{
    public class UserValidator
    {
        public static bool checktValidation(params string[] text)
        {
            bool verification1 = false;
            bool verification2 = true;
            foreach (var item in text)
            {
                if (!string.IsNullOrWhiteSpace(item) && !string.IsNullOrEmpty(item))
                    verification1 = true;

                else
                    verification2 = false;
            }
            if (!verification2)
                verification1 = false;
            return verification1;
        }
    }
}
