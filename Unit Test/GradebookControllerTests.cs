using generatorID.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace generatorID.Unit_Test
{
    using NUnit.Framework;
    [TestFixture]
    public class GradebookControllerTests
    {
        [Test]
        public void TestMethod0()
        {
            var controller = new SearchController();
            var result = controller.Index() as ViewResult;
            Assert.AreEqual(null, result.ViewName);
        }
    }
}