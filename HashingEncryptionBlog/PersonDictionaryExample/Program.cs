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
            personDictionary.Add("Carmel", new Person("Carmel", "Eve"));
        }

        private class Person
        {
            private string firstName;
            private string lastName;

            public Person(string firstName, string lastName)
            {
                this.firstName = firstName;
                this.lastName = lastName;
            }
        }
    }
}
