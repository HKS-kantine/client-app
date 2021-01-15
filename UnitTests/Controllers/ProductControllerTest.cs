using System.Collections.Generic;
using CollectionApp.Controllers;
using CollectionLogic.Entities;
using NUnit.Framework;

namespace UnitTests.Controllers
{
    public class ProductControllerTest
    {
        private readonly ProductsController _product = new ProductsController();
        private List<ProductEntity> _productList;

        [SetUp]
        public void Setup()
        {
        }

        [Test] public void CA_PR_01__receive_list_of_products()
        {
            _productList = _product.Get();
            if (_productList.Count >= 1)
            {
                Assert.Pass();
            }

            Assert.Fail("List is empty");
        }
    }
}