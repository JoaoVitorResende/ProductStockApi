using Microsoft.AspNetCore.Mvc;
using ProductStock.Application.UseCase.GetAll;
using ProductStock.Application.UseCase.Register.Products;
using ProductStock.Communication.Request;
using ProductStock.Communication.Response;

namespace ProductStock.Controllers
{
    [Route("api/products")]
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
        public IActionResult GetAll(
            [FromServices] IGetAllProducts useCase)
        {
            var response = useCase.Execute();
            return Ok(response);
        }
    }
}
