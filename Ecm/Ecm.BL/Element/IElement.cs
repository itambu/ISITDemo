using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecm.BL.Element
{
    public interface IElement
    {
        int Id { get; }

        string Name { get; }
        string Description { get; }
    }
}
