using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecm.BL.Category
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Category> Items { get; private set; }

        public Category(int id, string name, ICollection<Category> items )
        {
            Id = id;
            Name = name;
            Items = items;
        }
    }
}
