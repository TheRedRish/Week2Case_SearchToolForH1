using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Case_SearchToolForH1.Codes
{
    internal enum EnumH1
    {
        [Person(Name = "Rune Røddik Hansen", Status = "Elev", Subjects = new string[] { "Studieteknik", "Grundlæggende Programmering" })] RuneRøddikHansen,
        [Person(Name = "En anden elev", Status = "Elev", Subjects = new string[] { "Studieteknik", "Grundlæggende Programmering" })] EnAndenElev,
        [Person(Name = "Niels Olsen", Status = "Lærer", Subjects = new string[] { "Studieteknik", "Grundlæggende Programmering" })] NielsOlsen
    }

    public class PersonAttribute : Attribute
    {
        public string? Name { get; set; }
        public string? Status { get; set; } // Interface to define possible statuses? Elev or Lærer?
        public string[]? Subjects { get; set; } // Interface to define possible classes?
    }
}