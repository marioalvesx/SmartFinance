using Microsoft.AspNetCore.Mvc;
using SmartFinance.Application.UseCases.Expenses.Register;
using SmartFinance.Communication.Requests;
using SmartFinance.Communication.Responses;

namespace SmartFinance.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExpensesController : ControllerBase
{
    [HttpPost]
    public IActionResult Register([FromBody] RequestRegisterExpenseJson request)
    {
        try
        {
            var useCase = new RegisterExpenseUseCase();

            var response = useCase.Execute(request);

            return Created(string.Empty, response);
        }catch (ArgumentException ex)
        {
            var errorResponse = new ResponseErrorJson(ex.Message);

            return BadRequest(errorResponse);
        }
        catch
        {
            var errorResponse = new ResponseErrorJson("unknown error");

            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }

}
