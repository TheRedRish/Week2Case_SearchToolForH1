using System.Runtime.CompilerServices;
using Week2Case_SearchToolForH1.Codes;
using static System.Net.Mime.MediaTypeNames;

do
{
    Console.Clear();
    Console.WriteLine("Please choose an option:");
    Console.WriteLine("1. Teacher");
    Console.WriteLine("2. Student");
    Console.WriteLine("3. Subject");
    string? searchUserInput = Console.ReadLine();

    bool isAnOption = CheckUserInput.CheckIfUserInputMatchesCriteria(searchUserInput);

    if (!isAnOption)
    {
        DisplayErrorMessageForInputFor();
        continue;
    }
    // If number for Teacher or text of "Teacher" is input
    if (searchUserInput == ((int)EnumCriteria.Teacher).ToString() || searchUserInput.ToLower() == EnumCriteria.Teacher.ToString().ToLower())
    {
        //Get list of teachers and print with 5 per line
        Console.Clear();
        List<PersonModel> teachers = new PersonsList().PersonList.FindAll(p => p.Status == EnumCriteria.Teacher.ToString()).OrderBy(x => x.Name).ToList();
        Console.WriteLine("These are your options: ");
        for (int i = 0; i < teachers.Count; i++)
        {
            if (i != 0 && i % 5 == 0)
            {
                Console.WriteLine();
            }
            if (i < teachers.Count - 1)
            {
                Console.Write(teachers[i].Name + ", ");
            }
            else
            {
                Console.WriteLine(teachers[i].Name);
            }
        }
        Console.Write("Insert the name of the teacher you want to find: ");
        string searchName = Console.ReadLine();

        PersonModel? personModel = Search.GetPerson(searchName);

        //Get list with lines to print of subjects and the students in the given subject
        List<string>? subjectWithSudents = Search.GetSubjectWithSudents(personModel);

        if (subjectWithSudents == null)
        {
            DisplayErrorMessageForInputFor();
            continue;
        }
        foreach (string line in subjectWithSudents)
        {
            Console.WriteLine(line);
        }
    }
    // If number for Student or text of "Student" is input
    else if (searchUserInput == ((int)EnumCriteria.Student).ToString() || searchUserInput.ToLower() == EnumCriteria.Student.ToString().ToLower())
    {
        //Get list of students and print with 5 per line
        Console.Clear();
        List<PersonModel> students = new PersonsList().PersonList.FindAll(p => p.Status == EnumCriteria.Student.ToString()).OrderBy(x => x.Name).ToList();
        Console.WriteLine("These are your options: ");
        for (int i = 0; i < students.Count; i++)
        {
            if (i != 0 && i % 5 == 0)
            {
                Console.WriteLine();
            }
            if (i < students.Count - 1)
            {
                Console.Write(students[i].Name + ", ");
            }
            else
            {
                Console.WriteLine(students[i].Name);
            }
        }
        Console.Write("Insert the name of the student you want to find: ");
        string searchName = Console.ReadLine();
        PersonModel? personModel = Search.GetPerson(searchName);

        //Get list with lines to print of subjects and the teachers with the given subject
        List<string>? subjectWithTeacher = Search.GetSubjectWithTeacher(personModel);

        if (subjectWithTeacher == null)
        {
            DisplayErrorMessageForInputFor();
            continue;
        }

        foreach (string line in subjectWithTeacher)
        {
            Console.WriteLine(line);
        }
    }
    // If number for Subject or text of "Subject" is input
    else if (searchUserInput == ((int)EnumCriteria.Subject).ToString() || searchUserInput.ToLower() == EnumCriteria.Subject.ToString().ToLower())
    {
        //Get list of students and print with 5 per line
        Console.Clear();
        List<PersonModel> allPersons = new PersonsList().PersonList;
        List<string> allSubjects = new();
        foreach (PersonModel person in allPersons)
        {
            allSubjects.AddRange(person.Subjects);
        }
        allSubjects = allSubjects.Distinct().ToList().OrderBy(x => x).ToList();
        Console.WriteLine("These are your options: ");
        for (int i = 0; i < allSubjects.Count; i++)
        {
            if (i != 0 && i % 5 == 0)
            {
                Console.WriteLine();
            }
            if (i < allSubjects.Count - 1)
            {
                Console.Write(allSubjects[i] + ", ");
            }
            else
            {
                Console.WriteLine(allSubjects[i]);
            }
        }
        Console.Write("Insert the name of the subject you want to find: ");
        string searchSubject = Console.ReadLine().ToString();
        List<PersonModel>? personsWithSubject = Search.GetPersonsWithSubject(searchSubject);

        //Get list of lines to print with Teachers and students of each subject
        List<string>? teachersAndStudents = Search.GetTeacherAndStudent(personsWithSubject);

        if (teachersAndStudents == null)
        {
            DisplayErrorMessageForInputFor();
            continue;
        }
        foreach (string line in teachersAndStudents)
        {
            Console.WriteLine(line);
        }
    }

    Console.Write("Do you want to shut down the application? y/n: ");
    string closeProgramUserInput = Console.ReadLine();
    if (closeProgramUserInput.ToLower() == "y")
    {
        break;
    }

} while (true);

static void DisplayErrorMessageForInputFor()
{
    Console.Write("Du har indtastet noget forkert, prøv igen");
    Console.ReadKey();
}