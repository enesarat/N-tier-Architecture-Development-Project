using NLayerArc.Business;
using NLayerArc.DataAccess;
using NLayerArc.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NLayerArc.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Product List:\n");
            //ProductManager manageProduct = new ProductManager(new EfProductAL());
            //var productList = manageProduct.GetAllItems();
            //foreach (var item in productList)
            //{
            //    Console.WriteLine(item.ProductId + " " + item.ProductName + " " + item.QuantityPerUnit + " " + item.UnitPrice + " " + item.UnitsOnOrder + " " + item.CategoryId);
            //    //Console.WriteLine(item.Id + " " + item.ProductBrand + " " + item.ProductName + " " + item.ProductCategory + " " + item.ProductQuantity + " " + item.ProductPrice + "(tl)");
            //}

            //Console.WriteLine("\n");
            //Product productToAdd = new Product() { ProductName = "Galaxy S20", QuantityPerUnit = "Samsung", CategoryId = 1, UnitsOnOrder = 5, UnitPrice = 7000/*Id = productList.Count+1, ProductName = "XPERIA Z10", ProductBrand = "Sony", ProductCategory = "Mobile Phone", ProductQuantity = 15, ProductPrice = 6000*/ };
            //Product productToDelete = new Product() { ProductId = 78, ProductName = "Galaxy S20", QuantityPerUnit = "Samsung", CategoryId = 1, UnitsOnOrder = 5, UnitPrice = 7000 };
            //Product productToUpdate = new Product() { ProductId = 79, ProductName = "Galaxy S10+", QuantityPerUnit = "Samsung", CategoryId = 1, UnitsOnOrder = 20, UnitPrice = 5999 };

            //try
            //{
            //    //manageProduct.Update(productToUpdate);
            //    //manageProduct.Delete(productToDelete);
            //    //manageProduct.Add(productToAdd);
            //}
            //catch (DuplicatedProductException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //var productList_new = manageProduct.GetAllItems();
            //foreach (var item in productList_new)
            //{
            //    Console.WriteLine(item.ProductId + " " + item.ProductName + " " + item.QuantityPerUnit + " " + item.UnitPrice + " " + item.UnitsOnOrder + " " + item.CategoryId);
            //    //Console.WriteLine(item.Id + " " + item.ProductBrand + " " + item.ProductName + " " + item.ProductCategory + " " + item.ProductQuantity + " " + item.ProductPrice + "(tl)");
            //}

            Console.WriteLine("Customer List:\n");
            CustomerManager manageCustomer= new CustomerManager(new EfCustomerAL());
            var customertList = manageCustomer.GetAllItems();
            foreach (var item in customertList)
            {
                Console.WriteLine(item.CustomerID + " " + item.ContactName+ " " + item.CompanyName+ " " + item.City+ " " + item.Address+ " " + item.Phone);
                //Console.WriteLine(item.Id + " " + item.ProductBrand + " " + item.ProductName + " " + item.ProductCategory + " " + item.ProductQuantity + " " + item.ProductPrice + "(tl)");
            }

            Console.WriteLine("\n");
            Customer customerToAdd = new Customer() { CustomerID = "XXX3", ContactName = "Johhny Arat", CompanyName= "EA_Soft", City = "Istanbul", Address= "34295", Phone = "5452745489" };
            Customer customerToDelete = new Customer() { CustomerID="XXX2", ContactName = "Enes Arat", CompanyName = "EA_Soft", City = "Istanbul", Address = "34295", Phone = "5452745489" };
            Customer customerToUpdate = new Customer() { CustomerID = "XXX1", ContactName = "Eren Arat", CompanyName = "AE_Soft", City = "Istanbul", Address = "34295", Phone = "XXXXXXXXXX" };

            try
            {
                //manageCustomer.Update(customerToUpdate);
                //manageCustomer.Delete(customerToDelete);
                //manageCustomer.Add(customerToAdd);
            }
            catch (DuplicatedProductException ex)
            {
                Console.WriteLine(ex.Message);
            }
            var customertList_new = manageCustomer.GetAllItems();
            foreach (var item in customertList_new)
            {
                Console.WriteLine(item.CustomerID + " " + item.ContactName+ " " + item.CompanyName+ " " + item.City+ " " + item.Address+ " " + item.Phone);
            }





            //Console.WriteLine("\n\n Product Details Without Category Name Info: \n");
            //SampleQuery(productList);

            // İki tablodan verileri eşleştirmek istediğimizde join işlemlerine başvururuz. Joinle kartezyen çarpımı yapılır "on" tagi ile istenen filtreleme tüm olasılıklar arasından bulunur.

            //List<Category> categoryList = new List<Category>()
            //{
            //    new Category{CategoryID=1,CategoryName="Smart Phone"},
            //    new Category{CategoryID=2,CategoryName="Notebook"},
            //};

            //var productListQuery = from x in productList
            //                       join y in categoryList
            //                       on x.ProductCategory equals y.CategoryID
            //                       where x.ProductPrice >= 7000
            //                       orderby x.ProductName ascending, x.ProductBrand descending
            //                       select new ProductDTO { Id = x.Id, ProductBrand = x.ProductBrand, ProductName = x.ProductName, ProductPrice = x.ProductPrice, CategoryName = y.CategoryName, ProductQuantity = x.ProductQuantity };

            //Console.WriteLine("\n\n Product Details From Join: \n");
            //foreach (var item in productListQuery)
            //{
            //    Console.WriteLine("Category:{0}  --  Product Name:{1} - Brand:{2} - Price:{3} - Quantity:{4}",item.CategoryName,item.ProductName,item.ProductBrand,item.ProductPrice,item.ProductQuantity);
            //}
        }

        //private static void SampleQuery(List<Product> productList)
        //{
        //    var productListQuery = from x in productList
        //                              where x.ProductPrice > 5000
        //                              orderby x.ProductName ascending, x.ProductBrand descending
        //                              select x;

        //    List<Product> queriedProducts = productListQuery.ToList();  //IEnumarable yani itere edilebilir referans yapımızı ToList methodu ile product listesine dönüştürdük.

        //    foreach (var item in queriedProducts)
        //    {
        //        Console.WriteLine("Category:{0}  --  Product Name:{1} - Brand:{2} - Price:{3} - Quantity:{4}", item.ProductCategory, item.ProductName, item.ProductBrand, item.ProductPrice, item.ProductQuantity);
        //    }
        //}
    }
}
