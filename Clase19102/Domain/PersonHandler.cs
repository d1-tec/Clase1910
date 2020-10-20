using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public static class PersonHandler
    {
        private static List<Person> people = new List<Person>();

        public static void Add(string name, string address)
        {
            people.Add(new Person() { Name = name, Address = address });
        }

        public static List<Person> GetPeople()
        {
            return people;
        }
    }
}
