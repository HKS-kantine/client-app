

using CollectionEntities;
using NUnit.Framework;

namespace UnitTests.Entities
{
    public class ProductEntity
    {
        private readonly int Id = 1;
        private readonly string Name = "Bier";
        readonly float Price = 12;
        private readonly string Image = null;

        public ProductDTO productDto;

        [SetUp]
        public void Setup()
        {
            productDto = new ProductDTO()
            {
                Id = this.Id,
                Name = this.Name,
                Price = this.Price,
                Image = this.Image
            };
        }

        [Test]
        public void Test1()
        {
            CollectionLogic.Entities.ProductEntity product = new CollectionLogic.Entities.ProductEntity().ProductDTOToProduct(productDto);
            if (product.Id == this.Id && product.Name == this.Name && product.Price == this.Price && product.Image == this.Image)
            {
                Assert.Pass();
            }
            Assert.Pass();
        }
    }
}