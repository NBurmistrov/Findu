using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class AddClaimsPrincipalFactory : UserClaimsPrincipalFactory<User, IdentityRole>
    {
        public AddClaimsPrincipalFactory(
           UserManager<User> userManager
           , RoleManager<IdentityRole> roleManager
           , IOptions<IdentityOptions> optionsAccessor)
       : base(userManager, roleManager, optionsAccessor)
        { }

        public async override Task<ClaimsPrincipal> CreateAsync(User user)
        {
            var principal = await base.CreateAsync(user);

            if (user.Name != null)
            {
                ((ClaimsIdentity)principal.Identity).AddClaims(new[] {
                new Claim("Name", user.Name.ToString())
            });
            }
            if (user.Id != null)
            {
                ((ClaimsIdentity)principal.Identity).AddClaims(new[] {
                new Claim("Id", user.Id.ToString())
            });
            }
            if (user.Surname != null)
            {
                ((ClaimsIdentity)principal.Identity).AddClaims(new[] {
                new Claim("Surname", user.Surname.ToString())
            });
            }
            if (user.Email != null)
            {
                ((ClaimsIdentity)principal.Identity).AddClaims(new[] {
                new Claim("Email", user.Email.ToString())
            });
            }
            return principal;
        }
    }
}
