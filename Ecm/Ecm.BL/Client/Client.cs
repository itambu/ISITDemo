using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecm.BL.Client
{
    public class Client : IClient
    {
        public int Id { get; private set; }

        public ClientProfile Profile { get; private set; }

        public Client(int id, ClientProfile profile)
        {
            Id = id;
            Profile = profile;
        }
    }
}
