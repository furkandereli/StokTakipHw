using Core.Persistence.Repositories;
using DataAccess.Context;
using DataAccess.Repositories.Abstracts;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Concrete;

public class CategoryRepository : EfRepositoryBase<BaseDbContext, Category, int>, ICategoryRepository
{
    public CategoryRepository(BaseDbContext context) : base(context)
    {
    }


}
