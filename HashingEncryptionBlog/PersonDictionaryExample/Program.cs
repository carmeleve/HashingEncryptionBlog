using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashingEncryptionBlog
{
    class Program
    {
        static void Main(string[] args)
        {
            var personDictionary = new Dictionary<string, Person>();
            var me = new Person("Carmel", "Eve");
            personDictionary.Add(me.firstName, me);

            Console.WriteLine(personDictionary.ContainsKey("Carmel"));
        }

        private class Person
        {
            public readonly string firstName;
            public readonly string lastName;

            public Person(string firstName, string lastName)
            {
                this.firstName = firstName;
                this.lastName = lastName;
            }
        }
    }
}
