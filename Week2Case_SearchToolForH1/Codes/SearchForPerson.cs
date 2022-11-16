using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Week2Case_SearchToolForH1.Codes
{
    internal class SearchForPerson : IPerson
    {
        public PersonModel? Person { get; set; }

        public SearchForPerson(PersonModel? person)
        {
            Person = person;
            if (Person == null)
            {
                throw new ArgumentNullException(nameof(Person));
            }
            if (Person.Name != null)
            {                
                    Person.Subjects = PersonSubjectsInformation();
                    Person.Status = PersonStatusInformation();
            }
        }

        public string[]? PersonSubjectsInformation()
        {
            if (Person == null) { return null; }

            //Convert Enum to List for easier manipulation of data
            Array persons = Enum.GetValues(typeof(EnumH1));

            foreach (EnumH1 person in persons)
            {
                MemberInfo[] memberInfo = person.GetType().GetMember(person.ToString());
                PersonAttribute? personAttribute = memberInfo.First().GetCustomAttribute<PersonAttribute>();

                if (personAttribute != null && Person.Name == personAttribute.Name)
                {
                    return personAttribute.Subjects;
                }
            }

            return null;
        }
        public string? PersonStatusInformation()
        {
            if (Person == null) { return null; }

            //Convert Enum to List for easier manipulation of data
            Array persons = Enum.GetValues(typeof(EnumH1));

            foreach (EnumH1 person in persons)
            {
                MemberInfo[] memberInfo = person.GetType().GetMember(person.ToString());
                PersonAttribute? personAttribute = memberInfo.First().GetCustomAttribute<PersonAttribute>();

                if (personAttribute != null && Person.Name == personAttribute.Name)
                {
                    return personAttribute.Status;
                }
            }

            return null;
        }
    }
}
