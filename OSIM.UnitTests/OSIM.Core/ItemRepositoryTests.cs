using System;
using NUnit.Framework;
using OSIM.Core.Entities;
using OSIM.Core.Persistence;
namespace OSIM.UnitTests.OSIM.Core
{
    public class when_work_with_the_item_type_repository : Specification
    {

    }

    public class and_saving_a_valid_item_type : when_work_with_the_item_type_repository
    {
        private int _result;
        private ItemTypeRepository _itemTypeRepository;
        private ItemType _testItemType;
        private int _itemTypeId;
        [SetUp]
        public void Setup()
        {
            _itemTypeRepository = new ItemTypeRepository();
        }
        protected void Because_of()
        {
            _result = _itemTypeRepository.Save(_testItemType);
        }
        [Test]
        public void then_a_valid_item_type_id_should_be_returned()
        {
            Assert.AreEqual(_result, _testItemType);
        }
    }

}
