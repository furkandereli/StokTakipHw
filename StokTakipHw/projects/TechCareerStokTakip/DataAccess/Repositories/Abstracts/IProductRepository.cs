using Core.Persistence.Repositories;
using Models.Dtos.ResponseDto;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Abstracts;

public interface IProductRepository : IEntityRepository<Product,Guid>
{
    List<ProductDetailDto> GetAllProductDetails();
    List<ProductDetailDto> GetDetailsByCategoryId(int categoryId);
    ProductDetailDto GetProductDetail(Guid id);
}
