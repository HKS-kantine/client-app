

using System.Collections.Generic;
using CollectionEntities;
using CollectionLogic.Entities;
using NUnit.Framework;

namespace UnitTests.Entities
{
    public class OrderList
    {
        private readonly int Id = 1;
        private readonly List<OrderDTO> _orderDtos = new List<OrderDTO>();
        private readonly List<CollectionLogic.Entities.OrderEntity> _orders = new List<CollectionLogic.Entities.OrderEntity>();

        private OrderListDTO _orderListDto;
        private OrderListEntity _orderListEntity;

        [SetUp]
        public void Setup()
        {
            UserEntity user = new UserEntity();
            OrderEntity order = new OrderEntity();

            user.Setup();
            order.Setup();

            _orderDtos.Add(order.orderDto);
            _orders.Add(order.orderEntity);


            _orderListDto = new OrderListDTO()
            {
                Id = this.Id,
                Orders = _orderDtos,
                User = null
            };

            _orderListEntity = new OrderListEntity()
            {
                Id = this.Id,
                Orders = _orders,
                User = null

            };
        }

        [Test]
        public void Test1()
        {
            OrderListEntity orderList = new OrderListEntity().OrderListDTOToOrderList(_orderListDto);
            if (orderList.Id == this.Id)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void Test2()
        {
            OrderListDTO orderList = _orderListEntity.OrderToOrderDTO();
            if (orderList.Id == this.Id)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}