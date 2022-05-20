using BilgeAdam.Common.Dtos;
using BilgeAdam.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Services.Abstractions
{
    public interface ICategoryService
    {

        void Add(CategoryAddDto dto);
        void Delete(int id);
    }
}
