namespace lab2_task2
{
    public class task2
    {

        public static string InArea(int x, int y)
        {
            if (y >= 0 && (x * x + y * y == 100 || x * x + y * y == 25))
            {
                return "in line";
            }
            else if (y > 0 && x * x + y * y < 100 && x * x + y * y > 25)
            {
                return "in area";
            }
            else
            {
                return "out of area";
            }
        }

        static void Main()
        {
            bool proceed = true;
            while (proceed)
            {
                Console.WriteLine("\nThe program will check if your point is int specific area");
                Console.WriteLine("Enter 1 - to check, 2 - to exit the program");
                int a = Convert.ToInt16(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.WriteLine("Enter the X coordinate");
                        int x = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Enter the Y coordinate");
                        int y = Convert.ToInt16(Console.ReadLine());
                        
                        Console.WriteLine("The point is " + InArea(x, y));


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