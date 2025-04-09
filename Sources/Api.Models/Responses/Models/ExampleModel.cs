namespace Api.Models.Responses.Models
{
    /// <summary>
    /// Example of a shared api model (representation of DTO on different layer).
    /// The Model may be used by multiple Responses
    /// </summary>
    public class ExampleModel
    {
        public Guid Id { get; set; }

        public int Value { get; set; }
    }
}
