namespace HOMEWORK2;

class Program
{
    static void Main(string[] args)
    {
        // CODE FOR Q1 

        Console.WriteLine("Please input your grade: ");
        string grade = Console.ReadLine();

        // Using the swtich statement 

        switch (grade){
            case "A":
                Console.WriteLine("GPA Points: 4");
                break;
            case "B":
                Console.WriteLine("GPA Points: 3 ");
                break;
            case "C":
                Console.WriteLine("GPA Points: 2");
                break;
            case "D":
                Console.WriteLine("GPA Points: 1");
                break;
            case "F":
                Console.WriteLine("GPA Points: O");
                break;

            default:
                Console.WriteLine("Wrong Letter Grade!");
                break;

        }


        // CODE FOR Q2 

        // USER INPUT  NO 

        Console.WriteLine("Please enter the first number:");
        int num1 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Please enter the second number:");
        int num2 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Please enter the third number:");
        int num3 = Convert.ToInt16(Console.ReadLine());

        int smallest = num1;
        if(num2<smallest){
            smallest = num2;
        }
        if(num3<smallest){
            smallest = num3;
        }

        Console.WriteLine($"The smallest is: {smallest}");


       // BONUS QUESTION 

       Console.WriteLine("Please enter a year:");
       int year = Convert.ToInt16(Console.ReadLine());

       //A year is a leap year if;It is divisible by 4.
       //if it can be exactly divided by 100, then it isn't.
       // However, if it is divisible by 400 also. 

       if ((year % 4 == 0) && (year % 100 != 0 || year % 400 == 0))
        {
            Console.WriteLine($"{year} is a leap year.");
        }
        else{
            Console.WriteLine($"{year} is not a leap year.");
             }



    

        
    }
}
