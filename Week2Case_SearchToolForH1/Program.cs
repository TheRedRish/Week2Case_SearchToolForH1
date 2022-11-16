do
{
    Console.WriteLine("Vælg venligst hvad du vil søge på:");
    Console.WriteLine("1. Lærer");
    Console.WriteLine("2. Elev");
    Console.WriteLine("1. Fag");
    string? searchWord = Console.ReadLine();

    if (searchWord == null)
    {
        continue;
    }

    if (searchWord.ToLower() == "lærer" || searchWord.ToLower() == "elev")
    {
        SearchForPerson(searchWord);
    }
    else if (searchWord.ToLower() == "fag")
    {
        SearchForSubject? subjectOptions = new(searchWord);
        if (subjectOptions.PersonsWithSubject != null)
        {
            foreach (string person in subjectOptions.PersonsWithSubject)
            {
                SearchForPerson(person);
            }
        }
    }
} while (true);

void SearchForPerson(string searchWord)
{
    PersonModel? personModel = null;
    personModel = new() { Name = searchWord };
    SearchForPerson? personOptions = new(personModel);

    if (personOptions.Person != null && personOptions.Person.Status != null && personOptions.Person.Name != null && personOptions.Person.Subjects != null)
    {
        Console.WriteLine(personOptions.Person.Name);
        Console.WriteLine(personOptions.Person.Status);
        foreach (string teacher in personOptions.Person.Subjects)
        {
            Console.WriteLine(teacher);
        }
    }
}
