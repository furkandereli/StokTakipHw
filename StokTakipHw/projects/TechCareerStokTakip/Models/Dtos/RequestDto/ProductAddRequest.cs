using Models.Entities;

namespace Models.Dtos.RequestDto;

public record ProductAddRequest(Guid Id, string Name, int Stock, decimal Price, int CategoryId)
{
    public static Product ConvertToEntity(ProductAddRequest request)
    {
     return new Product
        {
            Id = request.Id,
            Name = request.Name,
            Stock = request.Stock,
            Price = request.Price,
            CategoryId = request.CategoryId
        };
    }
}
