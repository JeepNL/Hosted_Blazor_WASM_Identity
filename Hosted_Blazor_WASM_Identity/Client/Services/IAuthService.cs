using Hosted_Blazor_WASM_Identity.Shared.Models;

namespace Hosted_Blazor_WASM_Identity.Client.Services
{
	public interface IAuthService
	{
		Task<LoginResult> Login(LoginModel loginModel);
		Task<RegisterResult> Register(RegisterModel registerModel);
		Task Logout();
	}
}
