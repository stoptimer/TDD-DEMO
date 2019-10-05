using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BusinessApplication.Core
{
    public interface IPersonRepository
    {
        Person GetPerson(int personId);
    }

    public class PersonRepository : IPersonRepository
    {
        private readonly IEnumerable<Person> _personList;
        public PersonRepository()
        {
            _personList = new List<Person>
            {
            new Person {Id = 1, FirstName = "John",LastName = "Doe"},
            new Person{Id = 2, FirstName = "Richard",LastName = "Roe"},
            new Person {Id = 1, FirstName = "Amy",LastName = "Adams"}
            };
        }
        public Person GetPerson(int personId)
        {
            return _personList.FirstOrDefault(person => person.Id == personId);
        }

    }
}
