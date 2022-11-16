using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Week2Case_SearchToolForH1.Codes
{
    internal class SearchForSubject
    {
        public string[]? PersonsWithSubject { get; set; }

        public SearchForSubject(string subject)
        {
            PersonsWithSubject = PersonSubjectsInformation(subject);
        }

        public string[]? PersonSubjectsInformation(string subject)
        {
            var personsWithGivenSubject = new List<string>();
            //Convert Enum to List for easier manipulation of data
            Array persons = Enum.GetValues(typeof(EnumH1));

            foreach (EnumH1 person in persons)
            {
                MemberInfo[] memberInfo = person.GetType().GetMember(person.ToString());
                PersonAttribute? personAttribute = memberInfo.First().GetCustomAttribute<PersonAttribute>();

                if (personAttribute != null && personAttribute.Subjects != null)
                {
                    string[] subjectsToLower = personAttribute.Subjects.Select(x => x.ToLower()).ToArray();
                    if (subjectsToLower.Contains(subject.ToLower()))
                    {
                        personsWithGivenSubject.Add(subject);
                    }
                }
            }

            return personsWithGivenSubject.ToArray();
        }
    }
}
