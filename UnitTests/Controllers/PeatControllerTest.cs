using CollectionApp.Controllers;
using CollectionLogic.Entities;
using NUnit.Framework;

namespace UnitTests.Controllers
{
    public class PeatControllerTest
    {
        private readonly PeatController _peat = new PeatController();
        private OrderEntity _orderEntity;

        [Test]
        public void Get_all_peat_orders()
        {
            if (_peat.Get().Count == 0)
            {
                Assert.Fail();
            }
            Assert.Pass();
        }
    }
}