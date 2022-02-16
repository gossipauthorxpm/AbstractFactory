using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class AmazonFactory : IFactory
    {
        public string? name { get; set; }
        public int price { get; set; }
        public Product product { get;}

        public AmazonFactory(Product product)
        {
            this.product = product;
        }

        public void GetInfoOfDeliver()
        {
            Console.WriteLine($"Компания {name} поставляет товар: {product.GetName} по цене - {price}");
        }
    }
}
