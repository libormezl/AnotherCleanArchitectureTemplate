using Application.Dtos;
using Application.Interfaces;
using Application.Mappers;
using MediatR;

namespace Application.Queries
{
    /// <summary>
    /// Example of a query. Result of the query should be response object with properties or with DTOs
    /// </summary>

    public record ExampleGetQuery(Guid Id) : IRequest<ExampleGetQueryResult>;

    public record ExampleGetQueryResult(ExampleDto Example) : IRequest;

    internal class ExampleGetQueryHandler(IExampleRepository repository) : IRequestHandler<ExampleGetQuery, ExampleGetQueryResult>
    {
        public async Task<ExampleGetQueryResult> Handle(ExampleGetQuery command, CancellationToken cancellationToken)
        {
            var example = await repository.GetAsync(command.Id);
            var model = example.ToModel();
            return new ExampleGetQueryResult(model);
        }
    }
}
