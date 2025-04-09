using Application.Interfaces;
using Domain.Entities;

namespace Infrastructure
{
    /// <summary>
    /// Implementation of IExampleRepository
    /// </summary>
    internal class ExampleRepository : IExampleRepository
    {
        public async Task<Example> GetAsync(Guid commandId)
        {
            Console.WriteLine($"GetAsync called with commandId: {commandId}");
            return new Example();
        }

        public async Task UpdateAsync(Example value)
        {
            Console.WriteLine($"UpdateAsync called");
        }
    }
}
