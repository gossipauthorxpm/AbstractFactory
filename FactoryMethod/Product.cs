using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Product
    {
        public string name;
        public Product(string name)
        {
            this.name = name;
        }
        public string GetName{ get { return name; } }

    }
}
