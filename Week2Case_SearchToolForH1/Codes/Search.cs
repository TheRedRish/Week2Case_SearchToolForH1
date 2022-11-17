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
        public static PersonModel? GetPerson(string searchName)
        {
            List<PersonModel> persons = new PersonsList().PersonList;
            return persons.Find(person => person.Name.ToLower() == searchName.ToLower());
        }
        public static List<PersonModel>? GetPersonsWithSubject(string subject)
        {
            List<PersonModel> persons = new PersonsList().PersonList;
            return persons.FindAll(person => Array.ConvertAll(person.Subjects, s => s.ToLower()).Contains(subject.ToLower()));
        }
        public static List<string>? GetSubjectWithSudents(PersonModel? personModel)
        {
            List<string> subjectWithSudents = new();
            if (personModel == null || personModel.Subjects == null)
            {
                return null;
            }
            foreach (string subject in personModel.Subjects)
            {
                subjectWithSudents.Add(subject + ":");
                List<PersonModel>? personsWithSubject = GetPersonsWithSubject(subject);
                if (personsWithSubject == null)
                {
                    continue; // Will it ever be null here? Since the Teacher already has the subject
                }
                List<PersonModel> studentsWithSubject = personsWithSubject.FindAll(person => person.Status == EnumCriteria.Student.ToString()).OrderBy(x => x.Name).ToList();
                if (studentsWithSubject.Count == 0)
                {
                    subjectWithSudents.Add("No student with this subject");
                }
                for (int i = 0; i < studentsWithSubject.Count; i++)
                {
                    subjectWithSudents.Add("- " + studentsWithSubject[i].Name);
                }

                subjectWithSudents.Add(""); // Adding empty space for spacing 
            }
            return subjectWithSudents;
        }
        public static List<string>? GetSubjectWithTeacher(PersonModel? personModel)
        {
            List<string> subjectWithTeacher = new();
            if (personModel == null || personModel.Subjects == null)
            {
                return null;
            }
            foreach (string subject in personModel.Subjects)
            {
                string subjectAndTeachers;
                subjectAndTeachers = subject + " - ";
                List<PersonModel>? personsWithSubject = GetPersonsWithSubject(subject);
                if (personsWithSubject == null)
                {
                    continue; // Will never be null as the person already has the subject
                }
                List<PersonModel> teachersWithSubject = personsWithSubject.FindAll(person => person.Status == EnumCriteria.Teacher.ToString()).OrderBy(x => x.Name).ToList();
                if (teachersWithSubject.Count == 0)
                {
                    subjectAndTeachers += "No teacher with this subject";
                }
                for (int i = 0; i < teachersWithSubject.Count; i++)
                {
                    subjectAndTeachers += teachersWithSubject[i].Name;
                    if (i != teachersWithSubject.Count - 1)
                    {
                        subjectAndTeachers += " & ";
                    }
                }
                subjectWithTeacher.Add(subjectAndTeachers);
            }
            return subjectWithTeacher;
        }
        public static List<string>? GetTeacherAndStudent(List<PersonModel> personsWithSubject)
        {
            List<string> teacherAndStudent = new();
            if (personsWithSubject.Count == 0)
            {
                return null;
            }
            List<PersonModel> teachersWithSubjectList = personsWithSubject.FindAll(person => person.Status == EnumCriteria.Teacher.ToString()).OrderBy(x => x.Name).ToList();
            for (int i = 0; i < teachersWithSubjectList.Count; i++)
            {
                string teachersWithSubject = "Teachers with subject: ";
                teachersWithSubject += teachersWithSubjectList[i].Name;
                if (i != teachersWithSubjectList.Count - 1)
                {
                    teachersWithSubject += " & ";
                }
                teacherAndStudent.Add(teachersWithSubject);
            }

            List<PersonModel> studentsWithSubject = personsWithSubject.FindAll(person => person.Status == EnumCriteria.Student.ToString()).OrderBy(x => x.Name).ToList();
            foreach (PersonModel student in studentsWithSubject)
            {
                teacherAndStudent.Add("- " + student.Name);
            }

            return teacherAndStudent;
        }
    }
}
