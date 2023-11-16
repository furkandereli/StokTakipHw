using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dtos.ResponseDto;
public record CategoryResponseDto(int Id, string Name)
{
    public static implicit operator CategoryResponseDto(Category category)
    {
        return new CategoryResponseDto(Id: category.Id, Name:category.Name);
    }

    // CategoryResponseDto response = category

}
