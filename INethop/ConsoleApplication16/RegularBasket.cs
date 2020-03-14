using ConsoleApplication16.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    public class RegularBasket : Basket, IBasket
    {
        public RegularBasket(ICollection<ISaleItem> items) : base(items)
        {
        }

        public double Total
        {
            get
            {
                return (Items != null) ? Items.Sum(x => x.Total) : 0;
            }
        }
    }
}
