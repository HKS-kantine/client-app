using CollectionApp.Controllers;
using CollectionLogic.Entities;
using NUnit.Framework;

namespace UnitTests.Controllers
{
    public class OrderControllerTest
    {
        private readonly OrderController _order = new OrderController(null, null, null);
        private OrderEntity _orderEntity;
        [SetUp]
        public void Setup()
        {
            _orderEntity = _order.Get(1);
        }

        [Test]
        public void Get_all_orders()
        {
            if (_order.Get() == null)
            {
                Assert.Fail();
            }
            Assert.Pass();
        }

        [Test]
        public void Get_one_order()
        {
            if (_order.Get(1) == null)
            {
                Assert.Fail();
            }
            Assert.Pass();
        }

        [Test]
        public void Update_one_order()
        {
            int newAmount = 5;
            int oldAmount = _orderEntity.Amount;
            _orderEntity.Amount = newAmount + oldAmount;

            _order.Post(_orderEntity);
            if (_orderEntity.Amount == (newAmount + oldAmount))
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}