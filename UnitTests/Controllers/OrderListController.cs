using CollectionApp.Controllers;
using NUnit.Framework;

namespace UnitTests.Controllers
{
    public class OrderListControllerTest
    {
        private readonly OrderListController _orderList = new OrderListController();


        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Get_all_ordersLists()
        {
            if (_orderList.Get() == null)
            {
                Assert.Fail();
            }
            Assert.Pass();
        }
    }
}