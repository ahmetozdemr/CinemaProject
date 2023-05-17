using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Utilities.Exception
{
    public class UserValidatorException:System.Exception
    {
        public UserValidatorException() : base()
        {

        }

        public UserValidatorException(string message) : base(message)
        {
        }

        public UserValidatorException(string message, System.Exception inner) : base(message, inner)
        {
            {

            }
        }
    }
}
