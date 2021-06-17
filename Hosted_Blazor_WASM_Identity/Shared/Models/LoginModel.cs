using System.ComponentModel.DataAnnotations;

namespace Hosted_Blazor_WASM_Identity.Shared.Models
{
	public class LoginModel
	{
		[Required]
		public string Email { get; set; }

		[Required]
		public string Password { get; set; }

		public bool RememberMe { get; set; }
	}
}
