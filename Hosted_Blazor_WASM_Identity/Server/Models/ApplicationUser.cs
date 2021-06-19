using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Hosted_Blazor_WASM_Identity.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string CustomClaim { get; set; }
		public string Notes { get; set; }
    }
}
