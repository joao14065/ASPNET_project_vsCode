using System.Threading;
using System;
using System.Collections.Generic;
using ASPNET_API_proj.Model;

namespace ASPNET_API_proj.Services.Implementations
{
    public class PersonService : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long Id)
        {

        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for(int i = 0; i < 8; i++){
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }

    
        public Person FindById(long Id)
        {
            return new Person{
                Id = IncrementAndGet(),
                FirstName = "João Paulo",
                LastName = "Novato",
                Address = "Ribeirão Preto",
                Gender = "M",
            };
        }

        public Person Update(Person person)
        {
            return person;
        }
        private Person MockPerson(int i)
        {
            return new Person{
                Id = IncrementAndGet(),
                FirstName = "First Name" + i,
                LastName = "Last Name" + i,
                Address = "Some Address" + i,
                Gender = "M",
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}