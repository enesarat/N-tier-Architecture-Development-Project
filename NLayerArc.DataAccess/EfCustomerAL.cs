using NLayerArc.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NLayerArc.DataAccess
{
    public class EfCustomerAL : ICustomerAL
    {
        public void Add(Customer customer)
        {
            using (NwDbContext dbContext = new NwDbContext())
            {
                var _customerToAdd = dbContext.Customers.SingleOrDefault(x => x.CustomerID == customer.CustomerID);
                if (_customerToAdd == null)
                {
                    dbContext.Customers.Add(customer);
                    dbContext.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Bu id başka bir müşteride kayıtlı durumda!");
                }
            }
            
        }

        public void Delete(Customer customer)
        {
            using (NwDbContext dbContext = new NwDbContext())
            {
                var _customerToDelete = dbContext.Customers.SingleOrDefault(x => x.CustomerID == customer.CustomerID);
                if (_customerToDelete != null)
                {
                    dbContext.Customers.Remove(customer);
                    dbContext.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Bu id ye sahip müşteri kaydı bulunamadı!");
                }
            }
        }

        public List<Customer> GetAllItems()
        {
            using (NwDbContext dbContext = new NwDbContext())
            {
                var _customerList = dbContext.Customers;
                return _customerList.ToList();
            }
        }

        public Customer GetById(string id)
        {
            using (NwDbContext dbContext = new NwDbContext())
            {
                var _customerById = dbContext.Customers.SingleOrDefault(x => x.CustomerID == id);
                return _customerById;
            }
        }

        public Customer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer customer)
        {
            using (NwDbContext dbContext = new NwDbContext())
            {
                var _customerToUpdate = dbContext.Customers.SingleOrDefault(x => x.CustomerID == customer.CustomerID);
                if (_customerToUpdate!=null)
                {
                    _customerToUpdate.ContactName = customer.ContactName;
                    _customerToUpdate.CompanyName = customer.CompanyName;
                    _customerToUpdate.City = customer.City;
                    _customerToUpdate.Address = customer.Address;
                    _customerToUpdate.Phone = customer.Phone;

                    dbContext.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Bu id ye sahip müşteri kaydı bulunamadı!");
                }
            }
        }
    }
}
