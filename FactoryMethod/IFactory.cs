using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public interface IFactory
    {
        string name { get; set; }
        int price { get; set; }
        Product product { get; }

        public void GetInfoOfDeliver();
    }
}
