namespace Application.Dtos
{
    /// <summary>
    /// DTOs are used to transfer complex data from application layer to presentation layer.
    /// It is better to wrap every dto with response object due to extendability.
    /// DTOs may be used by multiple response objects.
    /// It may be used as api model, when there is no need to map it to shared api model.
    /// </summary>
    public class ExampleDto
    {
        public Guid Id { get; set; }

        public int Value { get; set; }
    }
}
