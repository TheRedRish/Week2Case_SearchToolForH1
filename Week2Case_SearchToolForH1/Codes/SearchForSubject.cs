using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Week2Case_SearchToolForH1.Codes
{
    internal static class SearchForSubject
    {
        //public List<PersonModel>? PersonsWithSubject { get; set; }

        //public SearchForSubject(string subject)
        //{
        //    PersonsWithSubject = GetPersonsWithSubject(subject);
        //}

        
        //public string[]? GetPersonsWithSubject(string subject)
        //{
        //    var personsWithGivenSubject = new List<string>();
            
        //    Array persons = Enum.GetValues(typeof(EnumH1));

        //    foreach (EnumH1 person in persons)
        //    {
        //        MemberInfo[] memberInfo = person.GetType().GetMember(person.ToString());
        //        PersonAttribute? personAttribute = memberInfo.First().GetCustomAttribute<PersonAttribute>();

        //        if (personAttribute != null && personAttribute.Subjects != null && personAttribute.Name != null)
        //        {
        //            string[] subjectsToLower = personAttribute.Subjects.Select(x => x.ToLower()).ToArray();
        //            if (subjectsToLower.Contains(subject.ToLower()))
        //            {
        //                personsWithGivenSubject.Add(personAttribute.Name);
        //            }
        //        }
        //    }

        //    return personsWithGivenSubject.ToArray();
        //}
    }
}
