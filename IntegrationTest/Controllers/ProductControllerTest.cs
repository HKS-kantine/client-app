using System.Net;
using NUnit.Framework;
using System.Threading.Tasks;

namespace IntegrationTest
{
    public class ProductControllerTest: IntegrationTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task Get_all_productsAsync()
        {
            var response = await TestClient.GetAsync("/api/products");

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}