public class Program
{
    //Call the methods to test them in the Main method below
    static void Main(string[] args)
    {
        PrintThousand();
        EqualNums(5, 5);
        EvenOrOdd(6);
        PosOrNeg(-1);
        Console.WriteLine("What is your age?");
        int userAge = int.Parse(Console.ReadLine());
        VoteAge(userAge);
        Console.WriteLine("Please choose a number");
        int userNum = int.Parse(Console.ReadLine());
        rangeMethod(userNum);
        MultipTable(3);




    }
    //LukeWarm Section: Create methods below
    //Write a method that will print to the console all numbers 1000 through - 1000
    public static void PrintThousand()
    {
        for (int i = -1000; i <= 1000 && i >= -1000; i++)
        {
            Console.WriteLine(i);
        }
    }


    //Write a method that will print to the console numbers 3 through 999 by 3 each time
    public static void ThreeTimes()
    {
        for (int i = 3; i <= 999; i += 3)
        {
            Console.WriteLine(i);
        }
    }


    //Write a method to accept two integers as parameterss and check whether they are equal or not

    public static bool EqualNums(int a, int b)
    {
        if (a == b)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    //Write a method to check whether a given number is even or odd
    public static void EvenOrOdd(int c)
    {
        if (c % 2 == 0)
        {
            Console.WriteLine("Number is even");
        }
        else
        {
            Console.WriteLine("Number is odd");
        }
    }

    //Write a method to check whether a given number is positive or negative

    public static void PosOrNeg(int d)
    {
        if (d >= 0)
        {
            Console.WriteLine("Number is positive");
        }
        else
        {
            Console.WriteLine("Number is negative");
        }
    }


    //Write a method to read the age of a candidate and determine whether they can vote.
    //Hint: Use Parse or the safer TryParse() for an extra challenge
    //Parse()
    //TryParse()
    public static void VoteAge(int age)
    {

        if (age >= 18)
        {
            Console.WriteLine("You are old enough to vote.");
        }
        else
        {
            Console.WriteLine("Not old enough to vote yet.");
        }
    }

    //Heatin Up Section:
    //Write a method to check if an integer(from the user) is in the range -10 to 10

    public static void rangeMethod(int e)
    {
        if (e >= -10 && e <= 10)
        {
            Console.WriteLine("In range");
        }
        else
        {
            Console.WriteLine("Out of range");
        }
    }

    //Write a method to display the multiplication table(from 1 to 12) of a given integer
    public static void MultipTable(int f)
    {
        for (f = 0; f <= 12; f += f)
        {
            Console.WriteLine(f);
        }
    }



}