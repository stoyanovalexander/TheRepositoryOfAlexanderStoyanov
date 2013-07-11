using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1To3.StudentInfo
{
    class TestStudentInfo
    {
        static void Main()
        {
            Student milencho = new Student("Milen", "Petrov", "Jordanov", 23416, "Plovdiv, Trakiq, Block 341, ap. 4"
                , "0875635672", "milencho@abv.bg", University.TelerikUniversity, Faculty.InformaticsFaculty, Specialty.IT, 1);
            Student hurencho = new Student("Huren", "Bayractar", "Chkr", 13423, "Plovdiv, Trakiq, Block 66, apartament 22",
                "0876824674", "huren@abv.bg", University.UNSS, Faculty.InformaticsFaculty, Specialty.IT, 3);
            Console.WriteLine(milencho);
            Console.WriteLine();
            Console.WriteLine("Original:" + hurencho);
            Console.WriteLine("The hash code of hurencho:{0}", hurencho.GetHashCode());
            Console.WriteLine();
            Student copyOfHurencho = hurencho.Clone();
            Console.WriteLine("copyOfHurencho:{0}", copyOfHurencho);
            Console.WriteLine("The hash code of copyOfHurencho:{0}", copyOfHurencho.GetHashCode());
            Console.WriteLine();
            Console.WriteLine("Hurencho end copyOfHurencho are the same: {0}", hurencho.Equals(copyOfHurencho));
            Console.WriteLine();
            if (hurencho == copyOfHurencho)
            {
                Console.WriteLine("hurencho==çopyOfHurencho");
            }
            else
            {
                Console.WriteLine("hurencho!=çopyOfHurencho");
            }

            if (hurencho == milencho)
            {
                Console.WriteLine("hurencho!=milencho");
            }
            else
            {
                Console.WriteLine("hurencho!=milencho");
            }
            Console.WriteLine("===========================MY FRIENDS SORTED=================================");
            Student asencho = new Student("Asen", "Ivanov", "Konov", 34567, "Plovdiv, Trakiq, Block 31, ap. 3",
                "0883454879", "asen@abv.bg", University.NewBulgarianUniversity, Faculty.LiteratureFaculty, Specialty.IT, 2);
            Student ivancho = new Student("Ivan", "Petrov", "Ivanov", 28451, "Plovdiv, Trakiq, Block 346, ap. 32",
                "0864485123", "ivan@abv.bg", University.UNSS, Faculty.LiteratureFaculty, Specialty.IT, 2);
            Student hasancho = new Student("Hasan", "Pehlivan", "Moldowan", 4646, "Plovdiv, Trakiq, Block 45, ap. 33",
               "0864595235", "hasan@abv.bg", University.NewBulgarianUniversity, Faculty.MathematicsFaculty, Specialty.Litrature, 2);

            List<Student> myFriends = new List<Student>();
            myFriends.Add(asencho);
            myFriends.Add(ivancho);
            myFriends.Add(hasancho);
            LambadaSorting(myFriends);
        }

        static void LambadaSorting(List<Student> someArrOfStudents)
        {
            var arrAfterSort = someArrOfStudents.OrderBy(x => x.FirstName).ThenBy(x => x.SSN);
            foreach (var student in arrAfterSort)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.SSN);
            }
        }
    }
}
