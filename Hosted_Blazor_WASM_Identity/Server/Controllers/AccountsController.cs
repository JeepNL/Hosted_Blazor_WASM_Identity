using System.Linq;
using System.Threading.Tasks;
using Hosted_Blazor_WASM_Identity.Server.Models;
using Hosted_Blazor_WASM_Identity.Shared.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Hosted_Blazor_WASM_Identity.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AccountsController : ControllerBase
	{
		private static UserModel LoggedOutUser = new() { IsAuthenticated = false };

		private readonly UserManager<ApplicationUser> _userManager;

		public AccountsController(UserManager<ApplicationUser> userManager)
		{
			_userManager = userManager;
		}

		[HttpPost]
		public async Task<IActionResult> Post([FromBody] RegisterModel model)
		{
			var newUser = new ApplicationUser { UserName = model.Email, Email = model.Email };

			var result = await _userManager.CreateAsync(newUser, model.Password);

			if (!result.Succeeded)
			{
				var errors = result.Errors.Select(x => x.Description);

				return BadRequest(new RegisterResult { Successful = false, Errors = errors });
			}

			// Add all new users to the User role
			await _userManager.AddToRoleAsync(newUser, "User");

			// Add new users whose email starts with 'admin' to the Admin role
			if (newUser.Email.StartsWith("admin"))
			{
				await _userManager.AddToRoleAsync(newUser, "Admin");
			}

			return Ok(new RegisterResult { Successful = true });
		}
	}
}
