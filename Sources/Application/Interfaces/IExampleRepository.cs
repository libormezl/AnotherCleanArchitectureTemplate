using Domain.Entities;

namespace Application.Interfaces
{
    /// <summary>
    /// Interface of domain external dependency
    /// </summary>
    public interface IExampleRepository
    {
        Task<Example> GetAsync(Guid commandId);

        Task UpdateAsync(Example value);
    }
}
