

using System.Runtime.CompilerServices;
using CollectionEntities;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using NUnit.Framework;

namespace UnitTests.Entities
{
    public class OrderEntity
    {
        int Id = 1;
        ProductDTO Product = null;
        int Amount = 5;

        public OrderDTO orderDto;
        public CollectionLogic.Entities.OrderEntity orderEntity;

        [SetUp]
        public void Setup()
        {
            ProductEntity productEntity = new ProductEntity();
            productEntity.Setup();

            Product = productEntity.productDto;
            orderDto = new OrderDTO()
            {
                Id = this.Id,
                Name = Product.Id.ToString(),
                Amount = this.Amount,
            };

            orderEntity = new CollectionLogic.Entities.OrderEntity()
            {
                Id = this.Id,
                Product = new CollectionLogic.Entities.ProductEntity().ProductDTOToProduct(Product),
                Amount = this.Amount

            };
        }

        [Test]
        public void Test1()
        {
            CollectionLogic.Entities.OrderEntity order = new CollectionLogic.Entities.OrderEntity().OrderDTOToOrder(orderDto);
            if (order.Id == this.Id && order.Amount == this.Amount)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void Test2()
        {
            OrderDTO order = orderEntity.OrderToOrderDTO();
            if (order.Id == this.Id && order.Amount == this.Amount)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}