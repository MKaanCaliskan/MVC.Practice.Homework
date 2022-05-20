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
     class CategoryService : ICategoryService
    {
        private readonly NorthwindDbContext dbContext;
        public CategoryService(NorthwindDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
           
        
        public void Add(CategoryAddDto dto)
        {
            dbContext.Categories.Add(new Category
            {
                CategoryName = dto.Name,
                Description= dto.Decription
            });
            dbContext.SaveChanges();

        }
        public void Delete(int id)
        {
            var entity = dbContext.Categories.SingleOrDefault(x => x.CategoryID == id);
            if (entity is not null)
            {
                dbContext.Categories.Remove(entity);
            }
            dbContext.SaveChanges();
        }
    }
}
