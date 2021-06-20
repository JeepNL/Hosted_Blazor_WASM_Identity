using System;
using System.Net.Http;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using Hosted_Blazor_WASM_Identity.Client.Services;
using Hosted_Blazor_WASM_Identity.Client.Helpers;
using Hosted_Blazor_WASM_Identity.Shared.Helpers;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Hosted_Blazor_WASM_Identity.Client
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			var builder = WebAssemblyHostBuilder.CreateDefault(args);
			builder.RootComponents.Add<App>("#app");

			builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

			builder.Services.AddBlazoredLocalStorage();
			builder.Services.AddAuthorizationCore(config =>
			{
				config.AddPolicy(Policies.IsAdmin, Policies.IsAdminPolicy());
				config.AddPolicy(Policies.IsUser, Policies.IsUserPolicy());
			});
			builder.Services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>();
			builder.Services.AddScoped<IAuthService, AuthService>();

			await builder.Build().RunAsync();
		}
	}
}
