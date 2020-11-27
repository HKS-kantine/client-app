using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using CollectionApp;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestExecutor;

namespace NUnitTestLogic
{
    class IntegrationTest
    {

        protected readonly HttpClient TestClient;
        public IntegrationTest()
        {
            var appFactory = new WebApplicationFactory<Startup>();
            TestClient = appFactory.CreateClient();
        }
    }
}
