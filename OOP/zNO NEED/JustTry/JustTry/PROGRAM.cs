using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JustTry;


class Program
{
    static void Main()
    {
        Person anonimous = new Person();
        Console.WriteLine("Person 1: name: {0}, age: {1}",anonimous.Name??"[unnamed]",anonimous.Age);

        Person peter = new Person("Pet", 9999);
        Console.WriteLine("Person 2: name:{0}, age: {1}",peter.Name,peter.Age);
        Console.WriteLine();

        Point centerPoint = new Point();
        centerPoint.Name = "Center of the coordinate system";
        Console.WriteLine("First point:({0},{1}) has name:'{2}'",centerPoint.XCoord,centerPoint.YCoord,centerPoint.Name);

        Point point77 = new Point(7, 7);
        Console.WriteLine("Second point:({0},{1}) has name'{2}'",point77.XCoord,point77.YCoord,point77.Name);
        Console.WriteLine();

        // DEFINING PROPERTIES
        Rectangle firstRect = new Rectangle(5.0f, 3.0f);
        Console.WriteLine("Rectangle 1 is {0}x{1} and has area: {2}",firstRect.Height,firstRect.Width,firstRect.Area);

        Rectangle secondRect = new Rectangle(4.0f, 3.0f);
        Console.WriteLine("Rectangle 2 is {0}x{1} and has area: {2}",secondRect.Height,secondRect.Width,secondRect.Area);
        Console.WriteLine();

        UserProfile profile = new UserProfile(4344334, "Asen", "Pifov");
        Console.WriteLine(profile);
        Console.WriteLine();

        // METHODS
        Point p1 = new Point(2,3);
        Point p2 = new Point(3,4);
        Console.WriteLine(p1.CalculateDistance(p2));

        // DOGMEETING
        Console.Write("Enter first dog name: ");
        string dogName = Console.ReadLine();
        Console.Write("Enter first dog breed: ");
        string dogBreed = Console.ReadLine();

        Dog firstDog = new Dog(dogName, dogBreed);

        Dog secondDog = new Dog();
        Console.Write("Enter second dog name: ");
        secondDog.Name = Console.ReadLine();
        Console.Write("Enter second dog breed: ");
        secondDog.Breed = Console.ReadLine();

        Dog thirdDog = new Dog();
        Dog[] dogs = new Dog[] { firstDog, secondDog, thirdDog };
        foreach (Dog dog in dogs)
        {
            dog.saybau();
        }

        // DAYOFWEEK
        DaysOfWeek day = DaysOfWeek.wed;
        Console.WriteLine(day);

        day = DaysOfWeek.mon;
        Console.WriteLine(++day);

        Console.WriteLine((int)day);

        day = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), "mon");
        Console.WriteLine(day);

        // COFFEESIZE
        Coffee normalCoffee = new Coffee(CoffeeSize.Normal);
        Coffee doubleCoffee = new Coffee(CoffeeSize.Double);

        Console.WriteLine("The {0} coffee is {1} ml.",normalCoffee.Size,(int)normalCoffee.Size);
        Console.WriteLine("The {0} coffee is {1} ml.",doubleCoffee.Size,(int)doubleCoffee.Size);

        // SAVEPERSONINFO
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        try
        {
            SavePerson person = new SavePerson(name, age);
            Console.WriteLine("Hello {0}!", person.Name);
            Console.WriteLine("Your age is {0}.", person.Age);
        }
        catch(Exception ex)
        {
            Console.WriteLine("Can not create person object:"+ex);
        }
    }
}   
