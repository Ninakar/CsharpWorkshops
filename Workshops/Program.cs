using System;
using System.Diagnostics;

namespace Workshops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Nina");
            Console.WriteLine("Kariauli");
            Console.WriteLine("Nina Kariauli");
            var myName = "Nina ";
            myName = "Nino ";
            var mySurname = "Kariauli";
            var fullName1 = myName + mySurname;
            var fullName2 = "Nina " + "Kariauli";
            Console.WriteLine(myName);
            Console.WriteLine(mySurname);
            Console.WriteLine(myName + mySurname);
            Console.WriteLine(fullName1);
            Console.WriteLine(fullName2);
            var myName1 = "Nina";
            var mySurname1 = "Kariauli";
            var fullNAme3 = $"Hello everyone, my name is {myName1} {mySurname1}.";
            Console.WriteLine(fullNAme3);
            var fName = "Nino";
            var fSurname = "Kariauli";
            var name = string.Concat(fName, fSurname);
            Console.WriteLine(name);
            var csharpStudent = "Nina Kariauli";
            var csharpStudentsage = 30;
            Console.WriteLine(csharpStudent +" " +"is"+" " + csharpStudentsage+ " "+"years old");
            Console.WriteLine($"{csharpStudent} is {csharpStudentsage} years old");
            var firstName = 'N';
            var lastName = 'K';
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            var Initials = $"My initials are {firstName} {lastName}";
            Console.WriteLine(Initials);
            var myProfession = "IT Business Analyst";
            var myEmployer = "Information Technology Agency";
            var carrierInfo = $"I work at {myEmployer} as an {myProfession}";
            Console.WriteLine("Indicate Your Fullname:");
            var usersFullname = Console.ReadLine();
            Console.WriteLine("User's Fullname is:"+"Nina Kariauli");
            Console.WriteLine("Indicate Your Age");
            int usersAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("User's Age is:"+"30");
            int myCurrentage;
            myCurrentage = 30;
            Console.WriteLine(myCurrentage);
            int myAge = 30;
            myAge = 29;
            Console.WriteLine(myAge);
            int myAgenow = 30;
            int myFriendsagenow = 28;
            Console.WriteLine(myAgenow>myFriendsagenow);
            Console.WriteLine(myAgenow<myFriendsagenow);   
            double myWeight = 65.4;
            Console.WriteLine(myWeight);
            double myWeight2 = (int)myWeight;
            Console.WriteLine(myWeight2);
            int myAgeinmonths = 30 * 12 + 1;
            Console.WriteLine(myAgeinmonths);
            int myAgeindays = myAgeinmonths * 365 - 4;
            Console.WriteLine(myAgeindays);
            int myAgeinhours = myAgeindays * 24;
            double myAgeinhoursdouble = Convert.ToDouble(myAgeinhours);
            Console.WriteLine(myAgeinhoursdouble);
            Console.WriteLine(myAgeinhours);
            int hoursInweeks = 7 * 24;
            Console.WriteLine(hoursInweeks);
            double myAgeinweeksdouble = (myAgeinhoursdouble+1)/168;
            Console.WriteLine(myAgeinweeksdouble);
            Console.WriteLine(Convert.ToInt32(myAgeinweeksdouble));
        }
    }
}
