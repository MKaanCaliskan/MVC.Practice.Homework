using BilgeAdam.Common.Dtos;
using BilgeAdam.Data;
using BilgeAdam.Data.Entities;
using BilgeAdam.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Services.Concretes
{
    public class CustomerService :ICustomerService
    {

        private readonly NorthwindDbContext dbContext;

        public CustomerService(NorthwindDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Add(CustomersAddDto dto)
        {
            dbContext.Customers.Add(new Customer
            {
                CustomerID= (dto.Name).Substring(0,5).ToUpper(),
                CompanyName= dto.Name,
                ContactName= dto.ContactName,
                Country= dto.Country,
                City= dto.City,
                Phone= dto.Phone,
                PostalCode="DX4582",
                Fax="000885885550",
                Address="Deneme",
                ContactTitle="Deneme",
                Region= "Deneme"

          
            });
            dbContext.SaveChanges();
        }
        public void Delete(string id)
        {
            var entity = dbContext.Customers.SingleOrDefault(x => x.CustomerID == id);
            if (entity is not null)
            {
                dbContext.Customers.Remove(entity);
            }
            dbContext.SaveChanges();
        }
    }
}
