using NLayerArc.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NLayerArc.DataAccess
{
    public class EfProductAL:IProductAL
    {
        //List<Product> _products;
        public EfProductAL()
        {
            //_products = new List<Product>
            //{
            //   new Product{Id=1,ProductName="Galaxy S10",ProductBrand="Samsung",ProductCategory=1,ProductQuantity=15,ProductPrice=5000},
            //    new Product{Id=2,ProductName="Galaxy S20",ProductBrand="Samsung",ProductCategory=1,ProductQuantity=5,ProductPrice=7000},
            //    new Product{Id=3,ProductName="Iphone X",ProductBrand="Apple",ProductCategory=1,ProductQuantity=12,ProductPrice=5600},
            //    new Product{Id=4,ProductName="Iphone 12 Pro",ProductBrand="Apple",ProductCategory=1,ProductQuantity=8,ProductPrice=8000},
            //    new Product{Id=5,ProductName="Thinkpad Pro",ProductBrand="Lenovo",ProductCategory=2,ProductQuantity=10,ProductPrice=9500},
            //    new Product{Id=6,ProductName="Macbook Air",ProductBrand="Apple",ProductCategory=2,ProductQuantity=5,ProductPrice=5600},
            //    new Product{Id=7,ProductName="Abra A5",ProductBrand="Monster",ProductCategory=2,ProductQuantity=5,ProductPrice=8000},

            //};
        }

        public List<Product> GetAllItems()
        {
            using(NwDbContext dbContext = new NwDbContext())    // Diaposable Pattern
            {

                var productList = dbContext.Products;
                return productList.ToList();
            }
            
        }

        public Product GetById(int id)
        {
            using (NwDbContext dbContext = new NwDbContext())    // Diaposable Pattern
            {

                var product = dbContext.Products.SingleOrDefault(x=>x.ProductId==id);
                return product;
            }
        }

        public void Add(Product product)
        {
            using (NwDbContext dbContext = new NwDbContext())    // Diaposable Pattern
            {

                var _product = dbContext.Products.SingleOrDefault(x => x.ProductId == product.ProductId);
                if (_product == null)
                {
                    dbContext.Products.Add(product);
                    dbContext.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Bu id başka bir üründe kayıtlı durumda!");
                }
            }
        }

        public void Delete(Product product)
        {
            using (NwDbContext dbContext = new NwDbContext())    // Diaposable Pattern
            {

                var _product = dbContext.Products.SingleOrDefault(x => x.ProductId == product.ProductId);
                if(_product != null)
                {
                    dbContext.Products.Remove(_product);
                    dbContext.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Bu id ye sahip ürün kaydı bulunamadı!");
                }
            }
        }

        public void Update(Product product)
        {
            using (NwDbContext dbContext = new NwDbContext())    // Diaposable Pattern
            {

                var _product = dbContext.Products.SingleOrDefault(x => x.ProductId == product.ProductId);
                if (_product != null)
                {
                    _product.ProductName = product.ProductName;
                    _product.UnitPrice = product.UnitPrice;
                    _product.UnitsOnOrder = product.UnitsOnOrder;
                    _product.QuantityPerUnit = product.QuantityPerUnit;
                    _product.CategoryId = product.CategoryId;
                    
                    dbContext.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Bu id ye sahip ürün kaydı bulunamadı!");
                }
            }
        }

        public Product GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
