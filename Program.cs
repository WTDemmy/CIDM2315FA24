namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
      // Call Q1_method()
            Console.WriteLine("Q1: Find the largest of two numbers:");
            int largestTwo = Q1_method();
            Console.WriteLine($"Largest of the two numbers is: {largestTwo}");

            // Call Q2_method()
            Console.WriteLine("Q2: Find the largest of four numbers:");
            int largestFour = Q2_method();
            Console.WriteLine($"Largest of the four numbers is: {largestFour}");

            // Call Q3_method()
            Console.WriteLine("Q3: Account Creation Process:");
            createAccount();
        }

        // Q1_method: Find the largest of two integers
        static int Q1_method()
        {
            Console.Write("Enter the first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int b = int.Parse(Console.ReadLine());

            return (a > b) ? a : b;
        }

        // Q2_method: Find the largest of four integers 
        static int Q2_method()
        {
            // Get four integers from the user
            Console.Write("Enter the first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("Enter the fourth number: ");
            int d = int.Parse(Console.ReadLine());

            
            int max1 = Q1_compare(a, b);  
            int max2 = Q1_compare(c, d);  

            return Q1_compare(max1, max2);
        }

        // Method for Q2 that reuses Q1 logic
        static int Q1_compare(int x, int y)
        {
            return (x > y) ? x : y;
        }

        // Q3_method: Account Creation Process
        static void createAccount()
        {
            Console.Write("Enter a username: ");
            string username = Console.ReadLine();

            Console.Write("Enter a password: ");
            string password = Console.ReadLine();

            Console.Write("Confirm your password: ");
            string confirmPassword = Console.ReadLine();

            Console.Write("Enter your birth year: ");
            int birthYear = int.Parse(Console.ReadLine());

            // Call checkAge to see if the user is over 18
            if (checkAge(birthYear))
            {
                // Check if passwords match
                if (password == confirmPassword)
                {
                    Console.WriteLine($"Account for {username} is created successfully");
                }
                else
                {
                    Console.WriteLine("Wrong password");
                }
            }
            else
            {
                Console.WriteLine("Could not create an account");
            }
        }

        static bool checkAge(int birth_year)
        {
            int currentYear = DateTime.Now.Year;
            int age = currentYear - birth_year;

            // Return true if age is 18 or older
            return age >= 18;
        }
      
      
       
    }

