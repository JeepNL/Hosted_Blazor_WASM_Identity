using System;
using Hosted_Blazor_WASM_Identity.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hosted_Blazor_WASM_Identity.Server.Data
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		public ApplicationDbContext(DbContextOptions options) : base(options)
		{
		}

		//protected override void OnModelCreating(ModelBuilder builder)
		//{
		//	base.OnModelCreating(builder);

		//	builder.Entity<IdentityRole>()
		//		   .HasData(new IdentityRole { Name = "User", NormalizedName = "USER", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
		//	builder.Entity<IdentityRole>()
		//		   .HasData(new IdentityRole { Name = "Admin", NormalizedName = "ADMIN", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
		//}
	}
}
