using Models.Entities;


namespace Models.Dtos.ResponseDto;
public record ProductResponseDto(Guid Id, string Name, int Stock, decimal Price, int CategoryId)
{
    public static ProductResponseDto ConvertToResponse(Product product)
    {

        return new ProductResponseDto(
            Id: product.Id,
            Name: product.Name,
            Stock: product.Stock,
            Price: product.Price,
            CategoryId: product.CategoryId 
            );
    }

}
