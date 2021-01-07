using CollectionApp.Controllers;
using NUnit.Framework;

namespace UnitTests.Controllers
{
    public class MyOrdersTest
    {
        private readonly MyOrdersController _myOrders = new MyOrdersController();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Receiving_My_Orders()
        {
            if (_myOrders.Get() == null)
            {
                Assert.Fail();
            }
            Assert.Pass();
        }
    }
}