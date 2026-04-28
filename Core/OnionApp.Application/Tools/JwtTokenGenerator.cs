using Microsoft.IdentityModel.Tokens;
using OnionApp.Application.Features.Results.AppUserResults;
using OnionApp.Application.Features.Results.TokenResults;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Application.Tools
{
    public class JwtTokenGenerator
    {
        public static GetTokenResponse GenerateToken(GetCheckAppUserQueryResult result)
        {
            var claims = new List<Claim>();
            if (!string.IsNullOrEmpty(result.Role))
                claims.Add(new Claim(ClaimTypes.Role, result.Role));
            claims.Add(new Claim(ClaimTypes.NameIdentifier, result.Id.ToString()));
            if(!string.IsNullOrEmpty(result.UserName))
                claims.Add(new Claim("Username",result.UserName));

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenDefaults.key));
            var signInCredential = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expireDate = DateTime.UtcNow.AddDays(JwtTokenDefaults.Expire);
            JwtSecurityToken token= new JwtSecurityToken(issuer:JwtTokenDefaults.ValidIssuer,audience:JwtTokenDefaults.ValidAudience,claims:claims,notBefore:DateTime.UtcNow,expires:expireDate,signingCredentials:signInCredential);

            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            return new GetTokenResponse(handler.WriteToken(token), expireDate);
        }
    }
}
