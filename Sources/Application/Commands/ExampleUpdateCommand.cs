using Application.Interfaces;
using MediatR;

namespace Application.Commands
{   
    /// <summary>
    /// Example of a command. Result of the command should be id or void
    /// </summary>

    public record ExampleUpdateCommand(Guid Id, int NewValue) : IRequest;

    internal class ExampleUpdateCommandHandler(IExampleRepository repository) : IRequestHandler<ExampleUpdateCommand>
    {
        public async Task Handle(ExampleUpdateCommand updateCommand, CancellationToken cancellationToken)
        {
            var example = await repository.GetAsync(updateCommand.Id);
            example.Value = updateCommand.NewValue;
            await repository.UpdateAsync(example);
        }
    }
}
