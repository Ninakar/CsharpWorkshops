using System;
using System.Diagnostics;

namespace Workshops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Nina"); //These lines are for the Name and Surname Exercises
            Console.WriteLine("Kariauli");
            Console.WriteLine("Nina Kariauli");

            String myName = "Nina ";
            myName = "Nino ";
            String mySurname = "Kariauli";
            string fullName1 = myName + mySurname;
            String fullName2 = "Nina " + "Kariauli";
            Console.WriteLine(myName);
            Console.WriteLine(mySurname);
            Console.WriteLine(myName + mySurname);
            Console.WriteLine(fullName1);
            Console.WriteLine(fullName2);


            //String Interpolation in C#
            string myName1 = "Nina";
            string mySurname1 = "Kariauli";
            string fullNAme3 = $"Hello everyone, my name is {myName1} {mySurname1}.";
            Console.WriteLine(fullNAme3);

            //Concatenate string in C#
            String fName = "Nino";
            String fSurname = "Kariauli";
            String name = string.Concat(fName, fSurname);
            Console.WriteLine(name);



            //Var keyword
            var csharpStudent = "Nina Kariauli";
            var csharpStudentsage = 30;
            Console.WriteLine(csharpStudent +" " +"is"+" " + csharpStudentsage+ " "+"years old");
            Console.WriteLine($"{csharpStudent} is {csharpStudentsage} years old");




            Char firstName = 'N';
            Char lastName = 'K';
           //Char myInittials = firstName + lastName; error it's not a string
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            String Initials = $"My initials are {firstName} {lastName}";
            Console.WriteLine(Initials);

            String myProfession = "IT Business Analyst";
            String myEmployer = "Information Technology Agency";
            String carrierInfo = $"I work at {myEmployer} as an {myProfession}";

            //User input
            Console.WriteLine("Indicate Your Fullname:");
            String usersFullname = Console.ReadLine();
            Console.WriteLine("User's Fullname is:"+"Nina Kariauli");

            Console.WriteLine("Indicate Your Age");
            int usersAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("User's Age is:"+"30");
            


            //These lines are for the age and other parameters

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
