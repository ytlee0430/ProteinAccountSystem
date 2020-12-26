using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using ProteinSystem.Entity;
using ProteinSystem.Repository.Entity;
using ProteinSystem.Service.AutoMapper;
using ProteinSystem.Service.Service;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetTest()
        {
            //var testRepository = new ItemRepository();
            //var x = testRepository.Get(i => i.Storage > -1);
            //var y = testRepository.Get(1);
            //var z = testRepository.GetAll();
            //Assert.AreEqual(1, x.First().Key);
            //Assert.AreEqual(1, z.First().Key);
            //Assert.AreEqual(1, y.Key);
        }

        [TestMethod]
        public void AddTest()
        {
            //var testRepository = new ItemRepository();
            //var x = testRepository.Add(new List<ItemEntity>
            //{
            //    new ItemEntity{
            //    Brand = 1,
            //    ItemCode = "1100",
            //    ExpiredDate = new DateTime(2020,04,30)},
            //    new ItemEntity{
            //        Brand = 2,
            //        ItemCode = "110022",
            //        ExpiredDate = new DateTime(2020,05,30)}
            //});
            //Assert.AreEqual(true, x);
        }

        [TestMethod]
        public void UpdateTest()
        {
            //var testRepository = new ItemRepository();
            //var x = testRepository.Update(new ItemEntity
            //{
            //    Key = 3,
            //    Brand = 1,
            //    ItemCode = "110022",
            //    ExpiredDate = new DateTime(2020, 04, 30)
            //});
            //Assert.AreEqual(true, x);
        }

        [TestMethod]
        public void ConvertDescriptionTest()
        {
            //var testRepository = new ItemRepository();
            //var x = testRepository.Update(new ItemEntity
            //{
            //    Key = 3,
            //    Brand = 1,
            //    ItemCode = "110022",
            //    ExpiredDate = new DateTime(2020, 04, 30)
            //});
            //var orderState = (OrderState)"待出貨".ConvertDescriptionToEnum(OrderState.Shipping);
            //Assert.AreEqual(OrderState.WaitingForShipment, orderState);
        }

        [TestMethod]
        public void MapperTest()
        {
            var item = new Item
            {
                Flavor = 14
            };
            Mapper.Initialize(x => x.CreateMap<Item, ItemEntity>());
            var itemEntity = Mapper.Map<ItemEntity>(item);
            Assert.AreEqual(itemEntity.Flavor, item.Flavor);
        }

        [TestMethod]
        public void ServiceMapperTest()
        {
            AutoMapperConfig.Configure();
            var item = new EnumEntity()
            {
                Description = "test",
                ForeignKey = 1,
            };
            var itemEntity = AutoMapperConfig.Map<EnumEntity, EnumModel>(item);
            Assert.AreEqual(itemEntity.Description, item.Description);
        }

        [TestMethod]
        public void ViewModelMapperTest()
        {
            EnumService.EnumInitialize();
            AutoMapperConfig.Configure();
            var item = new ItemEntity
            {
                Flavor = 14,
                Cost = 10
            };
            var itemEntity = AutoMapperConfig.Map<ItemEntity, ItemViewModel>(item);

            var test = AutoMapperConfig.Map<ItemViewModel, ItemEntity>(itemEntity);

            Assert.AreEqual(item.Flavor, test.Flavor);
        }

        [TestMethod]
        public void MapperListTest()
        {
            var items = new List<Item>{
            new Item
            {
                Flavor = 14
            }};

            Mapper.Initialize(x => x.CreateMap<Item, ItemEntity>());
            var itemEntity = Mapper.Map<List<ItemEntity>>(items);
            Assert.AreEqual(itemEntity.First().Flavor, items.First().Flavor);
        }
    }
}