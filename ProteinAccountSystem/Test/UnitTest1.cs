using System;
using System.Linq;
using CodeFirstORM.DBLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetTest()
        {
            var testRepository = new ItemRepository();
            var x = testRepository.GetList(i => i.Key == 1);
            Assert.AreEqual(1,x.First().Key);
        }
    }
}
