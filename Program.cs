namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        // CODE FOR QUE 1 

        Console.WriteLine("Input a number:");
        int N = Convert.ToInt16(Console.ReadLine());

        bool isPrime = true;
            for (int i = 2; i < N; i++)
            if (N <= 1){
                isPrime = false;
                    break;
                }

            else{
            
                for (int y = 2; y < N; y++)
                {
                    if (N % y == 0)
                    {
                        isPrime = false; 
                        break; 

                    }
                }
            }

            if (isPrime)
            {
                Console.WriteLine($"{N} is prime number.");
            }
            else
            {
                Console.WriteLine($"{N} is non-prime.");

            }


            // CODE FOR QUE 2

        Console.WriteLine("Input a value to integer D:");
        int D = Convert.ToInt16(Console.ReadLine());

        for (int row = 0; row < D; row++)
        {
            for (int col = 0; col < D; col++){
                Console.Write("#");
            }
            Console.WriteLine("");
        }

        // CODE FOR QUE 3 

        Console.WriteLine("Input a value to integer C:");
        int C = Convert.ToInt16(Console.ReadLine());

        for (int row = 0; row <C; row++) {
            for (int col = 0; col <C; col++){
                if(row>=col)
                Console.Write("*");
            }
            Console.WriteLine("");
        }


        // BONUS QUE CODE 

         Console.WriteLine("Input a number to integer Z:");
        int F = Convert.ToInt16(Console.ReadLine());

        for (int Z = 1; Z <= N; Z++)
        {

            for (int j = 1; j <= N - Z; j++)
            {
                Console.Write("1");
            }

            Console.WriteLine();

        }




















    }
}
