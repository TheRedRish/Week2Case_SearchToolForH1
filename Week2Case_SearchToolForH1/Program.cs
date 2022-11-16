using Week2Case_SearchToolForH1.Codes;

do
{
    Console.Clear();
    Console.WriteLine("Vælg venligst det nummer du vil søge på:");
    Console.WriteLine("1. Lærer");
    Console.WriteLine("2. Elev");
    Console.WriteLine("3. Fag");
    string? searchUserInput = Console.ReadLine();

    bool isAnOption = CheckUserInput(searchUserInput);

    if (!isAnOption)
    {
        DisplayErrorMessageForInputFor3Sec();
        continue;
    }

    if (searchUserInput == ((int)EnumCriteria.Teacher).ToString() || searchUserInput.ToLower() == EnumCriteria.Teacher.ToString().ToLower())
    {
        Console.Clear();
        Console.Write("Indtast navnet på læren du gerne vil søge på: ");
        string searchName = Console.ReadLine().ToString();

        PersonModel? personModel = Search.GetPerson(searchName);

        if (personModel == null)
        {
            DisplayErrorMessageForInputFor3Sec();
            continue;
        }
        foreach (string subject in personModel.Subjects)
        {
            Console.WriteLine(subject + ":");
            List<PersonModel>? personsWithSubject = Search.GetPersonsWithSubject(subject);
            if (personsWithSubject == null)
            {
                continue; // Will it ever be null here? Since the Teacher already has the subject
            }
            List<PersonModel> studentsWithSubject = personsWithSubject.FindAll(person => person.Status == EnumCriteria.Student.ToString());
            //List<PersonModel> studentsWithSubject = new();
            //foreach (PersonModel person in personsWithSubject)
            //{
            //    if (person.Status == EnumCriteria.Student.ToString())
            //    {
            //        studentsWithSubject.Add(person);
            //    }
            //}
            //= personsWithSubject.FindAll(teacher => teacher.Status == EnumCriteria.Teacher.ToString());
            if (studentsWithSubject.Count == 0)
            {
                Console.WriteLine("Ingen elever med dette fag");
            }
            for (int i = 0; i < studentsWithSubject.Count; i++)
            {
                Console.WriteLine("- " + studentsWithSubject[i].Name);
            }

            Console.WriteLine();
        }
    }
    else if (searchUserInput == ((int)EnumCriteria.Student).ToString() || searchUserInput.ToLower() == EnumCriteria.Student.ToString().ToLower())
    {
        Console.Clear();
        Console.Write("Indtast navnet på eleven du gerne vil søge på: ");
        string searchName = Console.ReadLine().ToString();
        PersonModel? personModel = Search.GetPerson(searchName);

        if (personModel == null || personModel.Subjects == null)
        {
            DisplayErrorMessageForInputFor3Sec();
            continue;
        }

        foreach (string subject in personModel.Subjects)
        {
            Console.Write(subject + " - ");
            List<PersonModel>? personsWithSubject = Search.GetPersonsWithSubject(subject);
            if (personsWithSubject == null)
            {
                continue; // Will it ever be null? Since the student already has the subject
            }
            List<PersonModel> teachersWithSubject = personsWithSubject.FindAll(person => person.Status == EnumCriteria.Teacher.ToString());
            //List<PersonModel> teachersWithSubject = new();
            //foreach (PersonModel person in personsWithSubject)
            //{
            //    if (person.Status == EnumCriteria.Teacher.ToString())
            //    {
            //        teachersWithSubject.Add(person);
            //    }
            //}
            //= personsWithSubject.FindAll(teacher => teacher.Status == EnumCriteria.Teacher.ToString());
            if (teachersWithSubject.Count == 0)
            {
                Console.WriteLine("Ingen lærer til dette fag");
            }
            for (int i = 0; i < teachersWithSubject.Count; i++)
            {
                Console.Write(teachersWithSubject[i].Name);
                if (i != teachersWithSubject.Count - 1)
                {
                    Console.Write(" & ");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
    else if (searchUserInput == ((int)EnumCriteria.Subject).ToString() || searchUserInput.ToLower() == EnumCriteria.Subject.ToString().ToLower())
    {
        Console.Clear();
        Console.Write("Indtast navnet på faget du gerne vil søge på: ");
        string searchSubject = Console.ReadLine().ToString();
        List<PersonModel>? personsWithSubject = Search.GetPersonsWithSubject(searchSubject);

        if (personsWithSubject == null)
        {
            DisplayErrorMessageForInputFor3Sec();
            continue;
        }
        List<PersonModel> teachersWithSubject = personsWithSubject.FindAll(person => person.Status == EnumCriteria.Teacher.ToString());
        for (int i = 0; i < teachersWithSubject.Count; i++)
        {
            Console.Write(teachersWithSubject[i].Name);
            if (i != teachersWithSubject.Count - 1)
            {
                Console.Write(" & ");
            }
            else
            {
                Console.WriteLine();
            }
        }

        List<PersonModel> studentsWithSubject = personsWithSubject.FindAll(person => person.Status == EnumCriteria.Student.ToString());
        foreach (PersonModel student in studentsWithSubject)
        {
            Console.WriteLine("- " + student.Name);
        }
    }

    Console.Write("Vil du lukke programmet ned? y/n: ");
    string closeProgramUserInput = Console.ReadLine().ToString();
    if (closeProgramUserInput.ToLower() == "y")
    {
        break;
    }

} while (true);

//static PersonModel? SearchForPerson(string searchWord)
//{
//    PersonModel? personModel = new() { Name = searchWord };
//    SearchForPerson? personOptions = new(personModel);

//    if (personOptions.Person != null)
//    {
//        return personOptions.Person;
//    }
//    return null;
//}
//static List<PersonModel> GetPersonsWithSubject(string searchSubject)
//{
//    var personsWithSubject = new List<PersonModel>();
//    SearchForSubject? subjectOptions = new(searchSubject);
//    if (subjectOptions.PersonsWithSubject != null)
//    {
//        foreach (string person in subjectOptions.PersonsWithSubject)
//        {
//            PersonModel? personModel = SearchForPerson(person);
//            if (personModel != null)
//            {
//                personsWithSubject.Add(personModel);
//            }
//        }
//    }

//    return personsWithSubject;
//}
static bool CheckUserInput(string userInput)
{
    bool isNumber = Int16.TryParse(userInput, out short searchNumber);
    List<string> criterias = Enum.GetNames(typeof(EnumCriteria)).ToList();
    criterias = criterias.ConvertAll(c => c.ToLower());

    if (criterias.Contains(userInput.ToLower()) || (isNumber && searchNumber < criterias.Count))
    {
        return true;
    }
    else
    {
        return false;
    }
}

static void DisplayErrorMessageForInputFor3Sec()
{
    Console.Write("Du har indtastet noget forkert, prøv igen");
    Console.ReadKey();
}