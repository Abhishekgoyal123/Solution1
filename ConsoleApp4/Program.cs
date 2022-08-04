// See https://aka.ms/new-console-template for more information



String[] a = { "Zero ", "One ", "Two ", "Three ", "Four ", "Five ", "Six ", "Seven ", "Eight ", "Nine " };

String[] b = {"Ten ", "Eleven ", "Twelve ", "Thirteen ", "Fourteen ", "Fifteen ", "Sixteen ", "Seventeen ", "Eighteen ", "Nineteen " };

String[] c = { "", "", "Twenty ", "Thirty ", "Forty ","Fifty ", "Sixty ", "Seventy ", "Eighty ", "Ninety " , "Hundred" };




int number = 41263, temp,temp1;

    if (number <= 99999)
    {
        if (number == 0)
        {
            Console.Write($" + {a[number]}");

        }

        if (number >= 1000)
        {

            temp = number / 1000;
            if (number % 10000 == 0)
            {
                temp = temp / 10;
                Console.Write($" {b[temp - 1]} Thousand ");
                return;

            }

            if (number % 1000 == 0)
            {
                Console.Write($"{a[temp]} Thousand ");
                return;
            }
            if (temp >= 10 && temp <= 19)
            {
                temp = temp % 10;
                Console.Write($"{b[temp]} +  ");
                temp = -1;
            }
            if (temp >= 20 && temp <= 99)
            {
                int i = temp / 10;
                temp = temp % 10;
                Console.Write($" {c[i]}");

            }
            if (temp > 0 && temp <= 9)
            {
                Console.Write($"{a[temp]}");
            }

            Console.Write("Thousand ");

            number = number % 1000;

        }
        if (number >= 100)
        {
            temp = number / 100;
            if (number % 100 == 0)
            {
                Console.Write($"{a[temp]} Hundred ");
                return;
            }

            number = number % 100;

            Console.Write($"{a[temp]} Hundred And ");

        }

        if (number >= 10 && number < 20)
        {

            temp = number % 10;

            Console.Write($"{b[temp]}");

        }

        if (number > 19 && number <= 100)
        {

            temp = number / 10;

            if (number == 100)
            {
                Console.Write($"{c[temp - 1]}");
                return;
            }

            number = number % 10;

            Console.Write($"{c[temp]}");

        }
        if (number < 10)
        {
            if (number != 0)
                Console.Write($"{a[number]}");

        }

    }
    else
    {
        Console.WriteLine("Enter a Smaller Number");
    }

