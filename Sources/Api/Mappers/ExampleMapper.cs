using Api.Models.Responses;
using Api.Models.Responses.Models;
using Application.Dtos;
using Application.Queries;

namespace Api.Mappers
{
    /// <summary>
    /// Mapper from query result to the shared api model
    /// </summary>
    internal static class ExampleMapper
    {
        public static ExampleQueryResponse ToResponse(this ExampleGetQueryResult result)
        {
            return new ExampleQueryResponse
            {
                Example = result.Example.ToModel()
            };
        }
        
        public static ExampleModel ToModel(this ExampleDto example)
        {
            return new ExampleModel
            {
                Id = example.Id,
                Value = example.Value
            };
        }
    }
}
