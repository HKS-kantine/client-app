using CollectionEntities;
using Newtonsoft.Json;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAuth
{
    public class AuthController : IAuth
    {
        private readonly Uri devUrl = new Uri("https://localhost:44365");
        private readonly Uri prodUrl =new Uri("https://431901-authentication-service.azurewebsites.net");

        private const string RequestUri = "https://localhost:44380/api/product";
        private static readonly HttpClient client = new HttpClient()
        {
            BaseAddress = new Uri("https://431901-authentication-service.azurewebsites.net")
        };

        public async Task<AuthDto> Login()
        {
            //client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(
            //    new MediaTypeWithQualityHeaderValue("application/json")
            //);
            HttpResponseMessage response = await client.PostAsync("/api/user", new StringContent(JsonConvert.SerializeObject(new { Username = "maarten.jakobs@gmail.com", Password = "sonu@123" }),
                                Encoding.UTF8, "application/json"));

            response.EnsureSuccessStatusCode();
            string result = response.Content.ReadAsStringAsync().Result;
            AuthDto accessToken = JsonConvert.DeserializeObject<AuthDto>(result);

            if (accessToken.auth_token == null)
            {
                return null;
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var paresedToken = tokenHandler.ReadJwtToken(accessToken.auth_token);

            return accessToken;
        }
    }
}
