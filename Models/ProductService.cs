using System;
using System.Collections.Generic;

namespace dockersampleapp.Models
{
    public class ProductService
    {
        private List<Product> list;

        public ProductService()
        {
            list= new List<Product>
            {
                new Product{Id=1,Name="Pens",Price=19.99},
                new Product{Id=2,Name="Toys",Price=199.55},
                new Product{Id=3,Name="Books",Price=250.22}
            };
        }

        public List<Product> GetProducts()
        {
            return list;
        }
    }
}