

using System.Collections.Generic;
using CollectionEntities;
using CollectionLogic.Entities;
using NUnit.Framework;

namespace UnitTests.Entities
{
    public class OrderList
    {
        private int Id = 1;
        private readonly List<OrderDTO> OrderDtos = new List<OrderDTO>();
        private readonly List<CollectionLogic.Entities.OrderEntity> Orders = new List<CollectionLogic.Entities.OrderEntity>();

        private OrderListDTO orderListDto;
        private OrderListEntity orderListEntity;

        [SetUp]
        public void Setup()
        {
            UserEntity user = new UserEntity();
            OrderEntity order = new OrderEntity();

            user.Setup();
            order.Setup();

            OrderDtos.Add(order.orderDto);
            Orders.Add(order.orderEntity);


            orderListDto = new OrderListDTO()
            {
                Id = this.Id,
                Orders = OrderDtos,
                User = null
            };

            orderListEntity = new CollectionLogic.Entities.OrderListEntity()
            {
                Id = this.Id,
                Orders = Orders,
                User = null

            };
        }

        [Test]
        public void Test1()
        {
            CollectionLogic.Entities.OrderListEntity orderList = new CollectionLogic.Entities.OrderListEntity().OrderListDTOToOrderList(orderListDto);
            if (orderList.Id == this.Id)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void Test2()
        {
            OrderListDTO orderList = orderListEntity.OrderToOrderDTO();
            if (orderList.Id == this.Id)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}