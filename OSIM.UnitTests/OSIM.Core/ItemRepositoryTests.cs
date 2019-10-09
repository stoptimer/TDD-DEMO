using System;
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
        private ItemTypeRepository _itemTypeRepository;
        private ItemType _testItemType;
        private int _itemTypeId;
        [SetUp]
        public void Setup()
        {
            var randomNumberGenerator = new Random();
            _itemTypeId = randomNumberGenerator.Next(32000);
            _itemTypeRepository = new ItemTypeRepository();
        }
        
        [Test]
        public void then_a_valid_item_type_id_should_be_returned()
        {
            _result = _itemTypeRepository.Save(_testItemType);
            Assert.AreEqual(_result, _itemTypeId);
        }
    }

}
