using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1.StudentsInCoursesSort
{
    class StudentsInCoursesSort
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("students.txt", Encoding.GetEncoding("UTF-8"));

            using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                List<Student> myPeople = new List<Student>();
                while (line != null)
                {
                    lineNumber++;
                    string[] studentsInfo = line.Split('|');
                    for (int i = 0; i < studentsInfo.Length; i++)
                    {
                        studentsInfo[i]=studentsInfo[i].Trim();
                    }
                    myPeople.Add(new Student(studentsInfo[0], studentsInfo[1], studentsInfo[2]));
                    line = reader.ReadLine();
                }

                List<string> disciplines = new List<string>();
                for (int i = 0; i < myPeople.Count; i++)
                {
                    disciplines.Add(myPeople[i].Discipline);
                }

                disciplines.Sort();
                List<string> noRepeatDisciplines = new List<string>();
                for (int i = 0; i < disciplines.Count-1; i++)
                {
                    if (disciplines[i] != disciplines[i+1])
                    {
                        noRepeatDisciplines.Add(disciplines[i]);
                    }
                }
                noRepeatDisciplines.Add(disciplines[disciplines.Count-1]);

                SortedDictionary<string, string> myDictionary = new SortedDictionary<string, string>();
                string myKey = null;
                for (int i = 0; i < myPeople.Count; i++)
                {
                    myKey = myPeople[i].LastName + " " + myPeople[i].FirstName;
                    myDictionary.Add(myKey, myPeople[i].Discipline);
                }

                for (int i = 0; i < noRepeatDisciplines.Count; i++)
                {
                    Console.Write(noRepeatDisciplines[i]+": ");
                    foreach (var pair in myDictionary)
                    {
                        if (pair.Value == noRepeatDisciplines[i])
                        {
                            string[] names = pair.Key.Split(' ');
                            Console.Write(names[1]+" "+names[0]+", ");
                        }
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}
