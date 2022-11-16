using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Week2Case_SearchToolForH1.Codes
{
    internal static class Search 
    {
        //public PersonModel? Person { get; set; }

        //public SearchForPerson(string searchName)
        //{
        //    Person = GetPerson(searchName);
        //}

        public static PersonModel? GetPerson(string searchName)
        {
            List<PersonModel> persons = PersonsList.GetPersonsList();

            return persons.Find(person => person.Name == searchName);
        }
        public static List<PersonModel>? GetPersonsWithSubject(string subject)
        {
            List<PersonModel> persons = PersonsList.GetPersonsList();

            return persons.FindAll(person => person.Subjects.Contains(subject));
        }
        //public string[]? PersonSubjectsInformation()
        //{
        //    if (Person == null) { return null; }            

        //    Array persons = Enum.GetValues(typeof(EnumH1));

        //    foreach (EnumH1 person in persons)
        //    {
        //        MemberInfo[] memberInfo = person.GetType().GetMember(person.ToString());
        //        PersonAttribute? personAttribute = memberInfo.First().GetCustomAttribute<PersonAttribute>();

        //        if (personAttribute != null && Person.Name == personAttribute.Name)
        //        {
        //            return personAttribute.Subjects;
        //        }
        //    }

        //    return null;
        //}
        //public string? PersonStatusInformation()
        //{
        //    if (Person == null) { return null; }

        //    Array persons = Enum.GetValues(typeof(EnumH1));

        //    foreach (EnumH1 person in persons)
        //    {
        //        MemberInfo[] memberInfo = person.GetType().GetMember(person.ToString());
        //        PersonAttribute? personAttribute = memberInfo.First().GetCustomAttribute<PersonAttribute>();

        //        if (personAttribute != null && Person.Name == personAttribute.Name)
        //        {
        //            return personAttribute.Status;
        //        }
        //    }

        //    return null;
        //}
    }
}
