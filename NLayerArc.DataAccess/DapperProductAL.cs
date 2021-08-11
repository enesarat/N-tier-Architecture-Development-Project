using NLayerArc.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerArc.DataAccess
{
    public class DapperProductAL : IProductAL
    {
        List<Product> _products;
        public DapperProductAL()
        {
            //_products = new List<Product>
            //{
            //    new Product{Id=1,ProductName="Galaxy S10",ProductBrand="Samsung",ProductCategory=1,ProductQuantity=15,ProductPrice=5000},
            //    new Product{Id=2,ProductName="Galaxy S20",ProductBrand="Samsung",ProductCategory=1,ProductQuantity=5,ProductPrice=7000},
            //    new Product{Id=3,ProductName="Iphone X",ProductBrand="Apple",ProductCategory=1,ProductQuantity=12,ProductPrice=5600},
            //    new Product{Id=4,ProductName="Iphone 12 Pro",ProductBrand="Apple",ProductCategory=1,ProductQuantity=8,ProductPrice=8000},
            //    new Product{Id=5,ProductName="Thinkpad Pro",ProductBrand="Lenovo",ProductCategory=2,ProductQuantity=10,ProductPrice=9500},
            //    new Product{Id=6,ProductName="Macbook Air",ProductBrand="Apple",ProductCategory=2,ProductQuantity=5,ProductPrice=5600},
            //    new Product{Id=7,ProductName="Abra A5",ProductBrand="Monster",ProductCategory=2,ProductQuantity=5,ProductPrice=8000},

            //};
        }

        public void Add(Product product)
        {
            _products.Add(product);
            
        }

        public void AddProduct()
        {
            Console.WriteLine("Dapper ile eklendi.");
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllItems()
        {
            return _products;
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
