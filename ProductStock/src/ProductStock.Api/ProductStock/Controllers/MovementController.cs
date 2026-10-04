using Microsoft.AspNetCore.Mvc;
using ProductStock.Application.UseCase.Register.Movement;
using ProductStock.Communication.Request;
using ProductStock.Communication.Response;

namespace ProductStock.Controllers
{
    [Route("api/Movements")]
    [ApiController]
    public class MovementController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseProduct), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseError), StatusCodes.Status400BadRequest)]
        public IActionResult Register(
            [FromServices] IRegisterMovement useCase,
            [FromBody] RequestMovement request)
        {
            var response = useCase.Execute(request);
            return Ok(response);
        }
    }
}
