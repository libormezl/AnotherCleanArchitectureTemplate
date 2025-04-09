using Api.Mappers;
using Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Api.Models.Requests;
using Application.Commands;

namespace Api.Controllers
{
    /// <summary>
    /// Presentation layer for the Application layer
    /// </summary>
    public class ExampleController(ISender sender) : Controller
    {
        [HttpGet("example/{guid}")]
        public async Task<IActionResult> Get([FromRoute] Guid guid)
        {
            var value = await sender.Send(new ExampleGetQuery(guid));
            var response = value.ToResponse();

            return Ok(response);
        }

        [HttpPost("example/{guid}")]
        public async Task<IActionResult> Post([FromRoute] Guid guid, [FromBody] ExampleUpdateRequest request)
        {
            await sender.Send(new ExampleUpdateCommand(guid, request.Value));

            return Ok();
        }
    }
}
