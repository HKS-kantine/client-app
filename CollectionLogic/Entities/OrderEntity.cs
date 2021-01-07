using CollectionEntities;
using CollectionFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionLogic.Entities
{
    public class OrderEntity
    {
        private readonly IProduct _ProductDal = ProductFactory.GetAssortiment();

        public int Id { get; set; }
        public ProductEntity Product { get; set; }
        public int Amount { get; set; }
        public OrderEntity OrderDTOToOrder(OrderDTO order)
        {
            return new OrderEntity()
            {
                Id = order.Id,
                Amount = order.Amount,
                Product = new ProductEntity().ProductDTOToProduct(_ProductDal.ReadOneAsync(order.ProductId).Result)
            };
        }
        public OrderDTO OrderToOrderDTO()
        {
            return new OrderDTO()
            {
                Id = this.Id,
                ProductId = this.Product.Id,
                Amount = this.Amount
            };
        }
    }
}
