
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
decimal x, y, z;
string continueExecution = "y";
do
{
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Substraction");
    Console.WriteLine("3. Multiply");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Square of a number");
    Console.WriteLine("6. Power of a number");
    Console.WriteLine("7. Square root of a number");

    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine("Enter x");
            x = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter y");
            y = Convert.ToDecimal(Console.ReadLine());
            z = x + y;
            Console.WriteLine($"Addition = {z}");
            break;
        case 2:
            Console.WriteLine("Enter x");
            x = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter y");
            y = Convert.ToDecimal(Console.ReadLine());
            z = x - y;
            Console.WriteLine($"Substraction = {z}");
            break;
        case 3:
            Console.WriteLine("Enter x");
            x = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter y");
            y = Convert.ToDecimal(Console.ReadLine());
            z = x * y;
            Console.WriteLine($"Multiplication = {z}");
            break;
        case 4:
            Console.WriteLine("Enter x");
            x = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter y");
            y = Convert.ToDecimal(Console.ReadLine());

            if(y==0)
            {
                Console.WriteLine("Division by 0 is not allowed");
                Console.WriteLine("enter y again");
                y = Convert.ToDecimal(Console.ReadLine());
            }
            z = x / y;
            Console.WriteLine($"Division = {z}");
            break;
        case 5:
            Console.WriteLine("Enter x");
            x = Convert.ToDecimal(Console.ReadLine());
            z = x * x;
            Console.WriteLine($"Square of x = {z}");
            break;
        case 6:
          biginteger n = 1;
            Console.WriteLine("Enter x");
            x = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter y");
            y = Convert.ToDecimal(Console.ReadLine());
            for (int i = 1; i <= y; i++)
            {
                n = n*x;
            }
            Console.WriteLine($"power = {n}");

            break;
        case 7:
            Console.WriteLine("Enter x");
            x = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(Convert.ToDouble(x)));
            break;

    }
    Console.WriteLine("Please enter y or Y to continue");
    continueExecution = Console.ReadLine();
    Console.Clear();
} while (continueExecution == "y" || continueExecution == "Y");

Console.ReadLine();










