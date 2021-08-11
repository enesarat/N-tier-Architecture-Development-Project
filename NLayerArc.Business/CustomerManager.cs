using NLayerArc.DataAccess;
using NLayerArc.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerArc.Business
{
    public class CustomerManager : ICustomerService
    {
        ICustomerAL accessData;
        public CustomerManager(ICustomerAL accessLevelType)
        {
            accessData = accessLevelType;
        }
        public void Add(Customer entity)
        {
            accessData.Add(entity);
        }

        public void Delete(Customer entity)
        {
            accessData.Delete(entity);
        }

        public List<Customer> GetAllItems()
        {
            var customerList = accessData.GetAllItems();
            return customerList;
        }

        public Customer GetById(string id)
        {
            var customer = accessData.GetById(id);
            return customer;
        }

        public Customer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            accessData.Update(entity);
        }
    }
}
