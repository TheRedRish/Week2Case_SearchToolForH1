using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Case_SearchToolForH1.Codes
{
    internal static class CheckUserInput
    {
        public static bool CheckIfUserInputMatchesCriteria(string userInput)
        {
            bool isNumber = Int16.TryParse(userInput, out short searchNumber);
            List<string> criterias = Enum.GetNames(typeof(EnumCriteria)).ToList();
            criterias = criterias.ConvertAll(c => c.ToLower());

            if (criterias.Contains(userInput.ToLower()) || (isNumber && searchNumber <= criterias.Count && searchNumber > 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
