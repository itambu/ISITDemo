using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecm.BL.Client
{
    public interface IClient
    {
        int Id { get; }

        ClientProfile Profile { get; }
    }
}
