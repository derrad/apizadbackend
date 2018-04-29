using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApiZadBackEnd;
using ApiZadBackEnd.Controllers;
using ApiZadBackEnd.Models;
using System.Web.Http.Results;

namespace ApiZadBackEnd.Tests.Controllers
{
    [TestClass]
    public class sfBankeControllerTest
    {
        [TestMethod]
        public async System.Threading.Tasks.Task GetAsync()
        {
            // Arrange
            bankeController controller = new bankeController();

            // Act
            var result = await controller.Getbanke(1) as OkNegotiatedContentResult<sfBanke> ;

            // Assert
          //  Assert.IsNotNull(value: result );
            // Assert.AreEqual(2, result...Count());
            Assert.AreEqual(false, result.Content.Aktivan  );
            //Assert.AreEqual("value2", result.ElementAt(1));
        }
    }
}

//namespace StoreApp.Tests
//{
//    [TestClass]
//    public class TestSimpleProductController
//    {
//        [TestMethod]
//        public void GetAllProducts_ShouldReturnAllProducts()
//        {
//            var testProducts = GetTestProducts();
//            var controller = new SimpleProductController(testProducts);

//            var result = controller.GetAllProducts() as List<Product>;
//            Assert.AreEqual(testProducts.Count, result.Count);
//        }

//        [TestMethod]
//        public async Task GetAllProductsAsync_ShouldReturnAllProducts()
//        {
//            var testProducts = GetTestProducts();
//            var controller = new SimpleProductController(testProducts);

//            var result = await controller.GetAllProductsAsync() as List<Product>;
//            Assert.AreEqual(testProducts.Count, result.Count);
//        }

//        [TestMethod]
//        public void GetProduct_ShouldReturnCorrectProduct()
//        {
//            var testProducts = GetTestProducts();
//            var controller = new SimpleProductController(testProducts);

//            var result = controller.GetProduct(4) as OkNegotiatedContentResult<Product>;
//            Assert.IsNotNull(result);
//            Assert.AreEqual(testProducts[3].Name, result.Content.Name);
//        }

//        [TestMethod]
//        public async Task GetProductAsync_ShouldReturnCorrectProduct()
//        {
//            var testProducts = GetTestProducts();
//            var controller = new SimpleProductController(testProducts);

//            var result = await controller.GetProductAsync(4) as OkNegotiatedContentResult<Product>;
//            Assert.IsNotNull(result);
//            Assert.AreEqual(testProducts[3].Name, result.Content.Name);
//        }

//        [TestMethod]
//        public void GetProduct_ShouldNotFindProduct()
//        {
//            var controller = new SimpleProductController(GetTestProducts());

//            var result = controller.GetProduct(999);
//            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
//        }

//        private List<Product> GetTestProducts()
//        {
//            var testProducts = new List<Product>();
//            testProducts.Add(new Product { Id = 1, Name = "Demo1", Price = 1 });
//            testProducts.Add(new Product { Id = 2, Name = "Demo2", Price = 3.75M });
//            testProducts.Add(new Product { Id = 3, Name = "Demo3", Price = 16.99M });
//            testProducts.Add(new Product { Id = 4, Name = "Demo4", Price = 11.00M });

//            return testProducts;
//        }
//    }
//}