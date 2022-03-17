namespace lab2_task1
{
    public class task1
    {
        public static bool IsIsosceles(int a, int b, int c)
        {
            if (a == b || a == c || b == c)
            {
                return true;
            }

            return false;
        }

        static void Main()
        {
            bool proceed = true;
            while (proceed)
            {
                Console.WriteLine("\nThe program will check if the triangle has 2 same sides");
                Console.WriteLine("Enter 1 - to check the triangle, 2 - to exit the program");
                int x = Convert.ToInt16(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Console.WriteLine("Enter the first side");
                        int a = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Enter the second side");
                        int b = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Enter the third side");
                        int c = Convert.ToInt16(Console.ReadLine());
                        if (IsIsosceles(a, b, c))
                        {
                            Console.WriteLine("The triangle is isosceles");
                        }
                        else
                        {
                            Console.WriteLine("The triangle is NOT isosceles");
                        }

                        break;
                    case 2:
                        proceed = false;
                        break;
                    default:
                        Console.WriteLine("Error, enter valid number");
                        break;
                }
            }
        }
    }
}