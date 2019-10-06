using BusinessApplication.Core;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessApplication.UnitTests
{
    [TestFixture]
    public class PersonServiceTests
    {
        private PersonService _personService;
        private Mock<IPersonRepository> _personRepository;
        [SetUp]
        public void SetUp()
        {
            _personRepository = new Mock<IPersonRepository>();
            _personRepository.Setup(x=>x.GetPerson(It.IsAny<int>())).Returns(new Person() { Id = 1, FirstName = "John", LastName = "Doa" });
            _personService = new PersonService(_personRepository.Object);
        }
        [Test]
        public void ShouldBeAbleToCallPersonServiceAndGetPerson()
        {
            var expected = new Person() { Id=1,FirstName="John",LastName="Doa"};
            var actual = _personService.GetPerson(expected.Id);
            Assert.AreEqual(expected.Id, actual.Id);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }
    }
}
