using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Case_SearchToolForH1.Codes
{
    internal interface IPersonList
    {
        public List<PersonModel> PersonList { get; set; }
        public List<PersonModel> GetPersonsList();
    }
}
