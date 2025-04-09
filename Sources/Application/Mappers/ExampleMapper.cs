using Application.Dtos;
using Domain.Entities;

namespace Application.Mappers
{
    /// <summary>
    /// Mapping from domain object to DTO
    /// </summary>
    internal static class ExampleMapper
    {
        public static ExampleDto ToModel(this Example example)
        {
            return new ExampleDto
            {
                Id = example.Id,
                Value = example.Value
            };
        }
    }
}
