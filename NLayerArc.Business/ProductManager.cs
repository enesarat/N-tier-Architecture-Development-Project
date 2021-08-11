using NLayerArc.DataAccess;
using NLayerArc.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerArc.Business
{
    public class ProductManager: IProductService
    {
        //EfProductAL accessData = new EfProductAL();
        IProductAL accessData;
        public ProductManager(IProductAL accessLevelType)
        {
            accessData = accessLevelType;
        }
        public List<Product> GetAllItems()
        {

            var productList = accessData.GetAllItems();
            return productList;
        }

        public Product GetById(int id)
        {
            return accessData.GetById(id);
        }

        public void Add(Product product)
        {
            accessData.Add(product);
        }

        public void Delete(Product product)
        {
            accessData.Delete(product);
        }

        public void Update(Product product)
        {
            accessData.Update(product);
        }

        public Product GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
