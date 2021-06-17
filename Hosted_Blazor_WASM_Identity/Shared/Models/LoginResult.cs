namespace Hosted_Blazor_WASM_Identity.Shared.Models
{
	public class LoginResult
	{
		public bool Successful { get; set; }
		public string Error { get; set; }
		public string Token { get; set; }
	}
}
