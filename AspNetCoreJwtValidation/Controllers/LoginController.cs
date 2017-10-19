using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace AspNetCoreJwtValidation.Controllers
{
    public class Login : Controller
    {
        private Users _users;
        public Login(Users users)
        {
            _users = users;
        }

        [HttpPost]
        [Route("api/login")]
        public IActionResult Index([FromBody]dynamic request)
        {
            var user = _users.GetUser((string)request.id, (string)request.password);
            return Ok(new JwtSecurityTokenHandler().WriteToken(CreateJwtSecurityToken(user)));
        }

        JwtSecurityToken CreateJwtSecurityToken(User user)
        {
            var claims = new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.Jti, Config.Id),
                new Claim(JwtRegisteredClaimNames.Sub, user.Name),
                new Claim(ClaimTypes.Sid, Config.Id),
                new Claim(ClaimTypes.Name , user.Name),
                new Claim(ClaimTypes.Role, user.Role)
            };

            var token = new JwtSecurityToken(
                issuer: Config.Issuer,
                audience: Config.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddDays(7),
                signingCredentials: new SigningCredentials(KeyStore.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256)
            );

            return token;
        }
    }
}
