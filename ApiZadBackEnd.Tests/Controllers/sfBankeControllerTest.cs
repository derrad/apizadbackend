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
