using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Horizon2000Rest.Core.Authentication
{
    internal class JwtHelper { 

        private static string Secret = "YU5kUmZValhuMnI1dTh4L0E/RChHK0tiUGVTaFZrWXAzczZ2OXkkQiZFKUhATWNRZlRqV25acTR0N3cheiVDKl9Ib3Jpem9uMjAwMF9kUmdVa1hwMnM1djh5L0I/RShHK0tiUGVTaFZtWXEzdDZ3OXokQyZGKUpATWNRZlRqV25acjR1N3ghQSVEKkct";

        /// <summary>
        /// Generates the token
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static string GenerateToken(string username)
        {
            byte[] key = Convert.FromBase64String(Secret);
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(key);
            SecurityTokenDescriptor descriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] {
                      new Claim(ClaimTypes.Name, username)}),
                Expires = DateTime.UtcNow.AddMinutes(30),
                SigningCredentials = new SigningCredentials(securityKey,
                SecurityAlgorithms.HmacSha256Signature)
            };

            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            JwtSecurityToken token = handler.CreateJwtSecurityToken(descriptor);
            return handler.WriteToken(token);
        }

        /// <summary>
        /// Gets the token parameters for checking
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public static TokenValidationParameters GetValidationParameters(string token)
        {
            try
            {
                JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
                JwtSecurityToken jwtToken = (JwtSecurityToken)tokenHandler.ReadToken(token);
                if (jwtToken == null)
                    return null;
                byte[] key = Convert.FromBase64String(Secret);
                TokenValidationParameters parameters = new TokenValidationParameters()
                {
                    RequireExpirationTime = true,
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    IssuerSigningKey = new SymmetricSecurityKey(key)
                };

                return parameters;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Gets the payloada from token
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public static ClaimsPrincipal GetPrincipal(string token)
        {
            try
            {
                var parameters = GetValidationParameters(token);
                JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
                SecurityToken securityToken;
                ClaimsPrincipal principal = tokenHandler.ValidateToken(token,
                      parameters, out securityToken);
                return principal;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Gets the expiration date, not needed cux validatioan already checks dates
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public static DateTime? TokenValidTo(string token)
        {
            try
            {
                var parameters = GetValidationParameters(token);
                JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();

                ClaimsPrincipal principal = tokenHandler.ValidateToken(token,
                      parameters, out SecurityToken validatedToken);
                return validatedToken.ValidTo;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Gets users username from token and validates the token
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public static string ValidateToken(string token)
        {
            string username = null;
            ClaimsPrincipal principal = GetPrincipal(token);
            if (principal == null)
                return null;
            ClaimsIdentity identity = null;
            try
            {
                identity = (ClaimsIdentity)principal.Identity;
            }
            catch (NullReferenceException)
            {
                return null;
            }
            username = identity.FindFirst(ClaimTypes.Name).Value;
            return username;
        }

    }
}

