using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using CodeFirstORM;
using CodeFirstORM.DBLayer;
using CommonUtility.Entity;
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
            var x = testRepository.GetList(i => i.Storage > -1);
            Assert.AreEqual(1, x.First().Key);

        }


        [TestMethod]
        public void MapperTest()
        {
            var item = new Item
            {
                Flavor = CommonUtility.Enum.FlavorEnum.Banana
            };
            Mapper.Initialize(x => x.CreateMap<Item, ItemEntity>());
            var itemEntity = Mapper.Map<ItemEntity>(item);
            Assert.AreEqual(itemEntity.Flavor, (int)item.Flavor);
        }

        [TestMethod]
        public void MapperListTest()
        {
            var items = new List<Item>{
            new Item
            {
                Flavor = CommonUtility.Enum.FlavorEnum.Banana
            }};

            Mapper.Initialize(x => x.CreateMap<Item, ItemEntity>());
            var itemEntity = Mapper.Map< List<ItemEntity>>(items);
            Assert.AreEqual(itemEntity.First().Flavor, (int)items.First().Flavor);
        }
    }
}
