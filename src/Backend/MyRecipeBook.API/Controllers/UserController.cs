using Microsoft.AspNetCore.Mvc;

using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Communication.Responses;

namespace MyRecipeBook.API.Controllers;

[ApiController]
public class UserController : ControllerBase {
	[HttpPost]
	[Route("register")]
	[ProducesResponseType(typeof(ResponseRegisteredUserJson), StatusCodes.Status201Created)]
	public IActionResult Register(RequestRegisterUserJson request) {
		return Created(string.Empty, new ResponseRegisteredUserJson {
			Name = request.Name,
		});
	}
}
