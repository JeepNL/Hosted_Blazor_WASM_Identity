using Microsoft.AspNetCore.Authorization;

namespace Hosted_Blazor_WASM_Identity.Shared
{
	public static class Policies
	{
		public const string IsAdmin = "IsAdmin";
		public const string IsUser = "IsUser";

		public static AuthorizationPolicy IsAdminPolicy()
		{
			return new AuthorizationPolicyBuilder().RequireAuthenticatedUser()
												   .RequireRole("Admin")
												   .Build();
		}

		public static AuthorizationPolicy IsUserPolicy()
		{
			return new AuthorizationPolicyBuilder().RequireAuthenticatedUser()
												   .RequireRole("User")
												   .Build();
		}
	}
}
