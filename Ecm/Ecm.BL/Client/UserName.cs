using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecm.BL.Client
{
    public struct UserName
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public UserName(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
