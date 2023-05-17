using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Utilities.Exception
{
    public class UserNameException :System.Exception
    {
        public UserNameException() : base()
        {

        }

        public UserNameException(string message) : base(message)
        {
        }

        public UserNameException(string message, System.Exception inner) : base(message, inner)
        {
            {

            }
        }
    }
}
