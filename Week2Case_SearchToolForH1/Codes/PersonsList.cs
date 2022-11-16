using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Case_SearchToolForH1.Codes
{
    internal static class PersonsList
    {
        public static List<PersonModel> GetPersonsList()
        {
            List<PersonModel> persons = new List<PersonModel>();
            persons.Add(new PersonModel() { Name = "Rune Røddik Hansen", Status = "Student", Subjects = new string[]{ "Clientsideprogrammering", "Studieteknik", "Grundlæggende Programmering", "OOP", "Databaseprogrammering", "Computerteknologi", "Netværk" } });
            persons.Add(new PersonModel() { Name = "Aleksander Runge", Status = "Student", Subjects = new string[] { "Clientsideprogrammering", "Studieteknik", "Grundlæggende Programmering", "OOP", "Databaseprogrammering", "Computerteknologi", "Netværk" } });
            persons.Add(new PersonModel() { Name = "Amanda Gudmand", Status = "Student", Subjects = new string[] { "Clientsideprogrammering", "Studieteknik", "Grundlæggende programmering", "OOP", "Databaseprogrammering", "Computerteknologi", "Netværk" } });
            persons.Add(new PersonModel() { Name = "Camilla Kløjgaard", Status = "Student", Subjects = new string[] { "Clientsideprogrammering", "Grundlæggende programmering", "OOP", "Databaseprogrammering", "Computerteknologi", "Netværk" } });
            persons.Add(new PersonModel() { Name = "Dennis Paaske", Status = "Student", Subjects = new string[] { "Clientsideprogrammering", "Studieteknik", "Grundlæggende programmering", "OOP", "Databaseprogrammering", "Computerteknologi", "Netværk" } });
            persons.Add(new PersonModel() { Name = "Iheb Boukthir", Status = "Student", Subjects = new string[] { "Clientsideprogrammering", "Studieteknik", "Grundlæggende programmering", "OOP", "Databaseprogrammering", "Computerteknologi", "Netværk" } });
            persons.Add(new PersonModel() { Name = "Jakob Rasmussen", Status = "Student", Subjects = new string[] { "Clientsideprogrammering", "Studieteknik", "Grundlæggende programmering", "OOP", "Databaseprogrammering", "Computerteknologi", "Netværk" } });
            persons.Add(new PersonModel() { Name = "Mikkel Rantala", Status = "Student", Subjects = new string[] { "Clientsideprogrammering", "Studieteknik", "Grundlæggende programmering", "OOP", "Databaseprogrammering", "Computerteknologi", "Netværk" } });
            persons.Add(new PersonModel() { Name = "Mikkel Jensen", Status = "Student", Subjects = new string[] { "Clientsideprogrammering", "Studieteknik", "Grundlæggende programmering", "OOP", "Databaseprogrammering", "Computerteknologi", "Netværk" } });
            persons.Add(new PersonModel() { Name = "Mikkel Kjærgaard", Status = "Student", Subjects = new string[] { "Clientsideprogrammering", "Studieteknik", "Grundlæggende programmering", "OOP", "Databaseprogrammering", "Computerteknologi", "Netværk" } });
            persons.Add(new PersonModel() { Name = "Niclas Jensen", Status = "Student", Subjects = new string[] { "Clientsideprogrammering", "Studieteknik", "Grundlæggende programmering", "OOP", "Databaseprogrammering", "Computerteknologi", "Netværk" } });
            persons.Add(new PersonModel() { Name = "Ozan Korkmaz", Status = "Student", Subjects = new string[] { "Clientsideprogrammering", "Grundlæggende programmering", "OOP", "Databaseprogrammering", "Computerteknologi", "Netværk" } });
            persons.Add(new PersonModel() { Name = "Rasmus Wiell", Status = "Student", Subjects = new string[] { "Clientsideprogrammering", "Studieteknik", "Grundlæggende programmering", "OOP", "Databaseprogrammering", "Computerteknologi", "Netværk" } });
            persons.Add(new PersonModel() { Name = "Sanjit Poudel", Status = "Student", Subjects = new string[] { "Clientsideprogrammering", "Studieteknik", "Grundlæggende programmering", "OOP", "Databaseprogrammering", "Computerteknologi", "Netværk" } });
            persons.Add(new PersonModel() { Name = "Adil Ajak", Status = "Student", Subjects = new string[] { "Clientsideprogrammering", "Studieteknik", "Grundlæggende programmering", "OOP", "Databaseprogrammering", "Computerteknologi", "Netværk" } });
            persons.Add(new PersonModel() { Name = "Peter Lindenskov", Status = "Teacher", Subjects = new string[] { "Clientsideprogrammering" } });
            persons.Add(new PersonModel() { Name = "Jan Johansen", Status = "Teacher", Subjects = new string[] { "Computerteknologi" } });
            persons.Add(new PersonModel() { Name = "Niels Olsen", Status = "Teacher", Subjects = new string[] { "Studieteknik", "Grundlæggende Programmering", "OOP", "Databaseprogrammering" } });
            persons.Add(new PersonModel() { Name = "Henrik Poulsen", Status = "Teacher", Subjects = new string[] { "Netværk" } });
            return persons;
        }
    }
}
