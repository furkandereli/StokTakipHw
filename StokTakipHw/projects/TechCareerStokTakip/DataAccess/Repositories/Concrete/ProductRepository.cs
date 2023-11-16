using Core.Persistence.Repositories;
using DataAccess.Context;
using DataAccess.Repositories.Abstracts;
using Models.Dtos.ResponseDto;
using Models.Entities;


namespace DataAccess.Repositories.Concrete
{
    public class ProductRepository : EfRepositoryBase<BaseDbContext, Product, Guid>, IProductRepository
    {
        public ProductRepository(BaseDbContext context) : base(context)
        {
        }

        public List<ProductDetailDto> GetAllProductDetails()
        {
            var details = Context.Products.Join(
                Context.Categories,
                p => p.CategoryId,
                c => c.Id,
                (product, category) => new ProductDetailDto
                {
                    Name = product.Name,
                    CategoryName = category.Name,
                    Id = product.Id,
                    Price = product.Price,
                    Stock= product.Stock
                }
                ).ToList();

            return details;
        }

        public List<ProductDetailDto> GetDetailsByCategoryId(int categoryId)
        {
            var values = Context.Products.
                Where(p => p.CategoryId == categoryId)
                .Join(
                Context.Categories,
                p => p.CategoryId,
                c => c.Id,
                (product, category) => new ProductDetailDto
                {
                    Name = product.Name,
                    CategoryName = category.Name,
                    Id = product.Id,
                    Price = product.Price,
                    Stock = product.Stock
                }
                ).ToList();

            return values;
        }

        public ProductDetailDto GetProductDetail(Guid id)
        {
            var details = Context.Products
                .Where(p => p.Id == id)
                .Select(product => new ProductDetailDto
                {
                    Name = product.Name,
                    CategoryName = product.Category.Name,
                    Id = product.Id,
                    Price = product.Price,
                    Stock = product.Stock
                }).FirstOrDefault();

            return details;
        }
    }
}
