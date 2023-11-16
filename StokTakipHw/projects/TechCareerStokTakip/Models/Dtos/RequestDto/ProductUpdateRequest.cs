using Models.Entities;
using System;
using System.Collections.Generic;


namespace Models.Dtos.RequestDto
{
    public record ProductUpdateRequest(Guid Id, string Name, int Stock, decimal Price, int CategoryId)
    {
        public static Product ConvertToEntity(ProductUpdateRequest request)
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
}
