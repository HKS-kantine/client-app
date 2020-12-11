using System.Net.Http;
using ClientApp;
using Microsoft.AspNetCore.Mvc.Testing;

namespace IntegrationTest
{
    public class IntegrationTest
    {
        protected readonly HttpClient TestClient;

        public IntegrationTest()
        {
            var appFactory = new WebApplicationFactory<Startup>();
            TestClient = appFactory.CreateClient();
        }
    }
}