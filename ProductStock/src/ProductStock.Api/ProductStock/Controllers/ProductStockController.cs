using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductStock.Application.UseCase.Register;
using ProductStock.Communication.Request;
using ProductStock.Communication.Response;

namespace ProductStock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductStockController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseProduct), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseError), StatusCodes.Status400BadRequest)]
        public IActionResult Register(
            [FromServices] IRegisterProduct useCase,
            [FromBody] RequestProduct request)
        {
            var response = useCase.Execute(request);
            return Ok(response);
        }

        [HttpGet]
        [ProducesResponseType(typeof(ResponseProduct), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseError), StatusCodes.Status400BadRequest)]
        public IActionResult GetAll(
            [FromServices] IRegisterProduct useCase,
            [FromBody] RequestProduct request)
        {
            var response = useCase.Execute(request);
            return Ok(response);
        }
    }
}
