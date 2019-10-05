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
            _personRepository.Setup(x=>x.GetPerson())
            _personService = new PersonService(_personRepository);
        }
    }
}
