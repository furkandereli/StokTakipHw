using Core.Persistence.EntityBaseModel;

namespace Models.Entities;

public class Product : Entity<Guid>
{
    public string Name { get; set; }
    public int  Stock { get; set; }
    public decimal Price { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; }

}
