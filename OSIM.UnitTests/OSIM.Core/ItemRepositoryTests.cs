using System;
using Moq;
using NUnit.Framework;
using OSIM.Core.Entities;
using OSIM.Core.Persistence;
namespace OSIM.UnitTests.OSIM.Core
{
    public class when_work_with_the_item_type_repository : Specification
    {

    }
    [TestFixture]
    public class and_saving_a_valid_item_type : when_work_with_the_item_type_repository
    {
        private int _result;
        
        private ItemType _testItemType;
        private int _itemTypeId;
        [SetUp]
        public void Setup()
        {
            var randomNumberGenerator = new Random();
            _itemTypeId = randomNumberGenerator.Next(32000);
           
        }
        
        [Test]
        public void then_a_valid_item_type_id_should_be_returned()
        {
            Mock<ItemTypeRepository> _itemTypeRepository = new Mock<ItemTypeRepository>();
            _testItemType = new ItemType() { Id=1};
            _itemTypeRepository.Setup(x => x.Save(It.IsAny<ItemType>())).Returns(_itemTypeId);
            _itemTypeRepository.sa
            Assert.AreEqual(_result, _itemTypeId);
        }
    }

}
