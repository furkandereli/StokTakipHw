using Core.Persistence.EntityBaseModel;
using Models.Dtos.RequestDto;

namespace Models.Entities;

public class Category : Entity<int>
{
    public string Name { get; set; }

    public List<Product> Products { get; set; }

 
    public static implicit operator Category(CategoryAddRequest categoryAddRequest) =>
        new Category { Name = categoryAddRequest.Name };


    public static implicit operator Category (CategoryUpdateRequest request)=>
        new Category { Name = request.Name,Id = request.Id};



}
