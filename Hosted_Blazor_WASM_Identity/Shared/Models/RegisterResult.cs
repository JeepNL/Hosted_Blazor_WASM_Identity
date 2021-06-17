using System.Collections.Generic;

namespace Hosted_Blazor_WASM_Identity.Shared.Models
{
	public class RegisterResult
	{
		public bool Successful { get; set; }
		public IEnumerable<string> Errors { get; set; }
	}
}
