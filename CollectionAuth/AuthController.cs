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

        private static readonly HttpClient client = new HttpClient()
        {
            BaseAddress = new Uri("https://431901-authentication-service.azurewebsites.net")
        };

        public async Task<AuthDto> Login(string User, string Password)
        {
            //client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(
            //    new MediaTypeWithQualityHeaderValue("application/json")
            //);
            HttpResponseMessage response = await client.PostAsync("/api/user", new StringContent(JsonConvert.SerializeObject(new { Username = User, Password }),
                                Encoding.UTF8, "application/json"));

            response.EnsureSuccessStatusCode();
            string result = response.Content.ReadAsStringAsync().Result;
            AuthDto accessToken = JsonConvert.DeserializeObject<AuthDto>(result);

            if (accessToken.auth_token == null)
            {
                return null;
            }

            return accessToken;
        }
    }
}
