using BilgeAdam.Common.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Services.Abstractions
{
    public interface ICustomerService
    {
        void Add(CustomersAddDto dto);
        void Delete(string id);
    }
}
