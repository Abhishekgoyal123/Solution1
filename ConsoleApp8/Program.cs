// See https://aka.ms/new-console-template for more information


List<string> lstString = new List<string>();


lstString.Add("Mahesh");
lstString.Add("Tejas");
lstString.Add("Mukesh");
lstString.Add("Satish");
lstString.Add("Vivek");
lstString.Add("Vinay");
lstString.Add("Sandeep");
lstString.Add("Nandu");
lstString.Add("Anil");
lstString.Add("Abhay");
lstString.Add("Jaywant");
lstString.Add("Shyam");
lstString.Add("Tushar");
lstString.Add("Sanjay");
lstString.Add("Sharad");
lstString.Add("Vijay");
lstString.Add("Abhay");
lstString.Add("Vilas");

List<int> lst1 = new List<int>();

lst1.Add(1);
lst1.Add(2);
lst1.Add(3);
lst1.Add(4);
lst1.Add(5);
lst1.Add(6);
lst1.Add(7);
lst1.Add(8);
lst1.Add(9);
lst1.Add(10);


string continueExecution = "y";
do
{
    Console.WriteLine("1. Sort List based on Length of each string");
    Console.WriteLine("2. Print index of even and odd number from the List");
    Console.WriteLine("3. Print index of prime numbers");
    Console.WriteLine("4. Search a Record in  List that contains 'A'");
    Console.WriteLine("5. Print string that starts from A M or K");
    Console.WriteLine("6. Find out count of repeated strings in an List of String");

    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            lstString.Sort();
            for (int i = 0; i < lstString.Count; i++)
            {
                for (int k = i + 1; k < lstString.Count; k++)
                {
                    if (lstString[i].Length > lstString[k].Length)
                    {
                        var temp = lstString[i];
                        lstString[i] = lstString[k];
                        lstString[k] = temp;

                    }
                }
            }

            for (int j = 0; j < lstString.Count; j++)
            {
                Console.WriteLine(lstString[j]);
            }

            Console.WriteLine("-----------------Reverse List-----------");

            for (int j = lstString.Count - 1; j >= 0; j--)
            {
                Console.WriteLine(lstString[j]);
            }
            break;
        case 2:
            for (int q = 0; q < lst1.Count - 1; q++)
            {
                if (lst1[q] % 2 == 0)
                    Console.WriteLine($"Index of even numbers are:{q}");
                else
                    Console.WriteLine($"Index of odd numbers are:{q}");

            }


            break;
        case 3:
            for (int m = 0; m < lst1.Count - 1; m++)
            {
                int flag = 0;
                if (lst1[m] == 0 || lst1[m] == 1)
                {
                    flag = 1;
                }
                for (float q = 2; q <= (lst1[m] / 2); q++)
                {
                    if ((lst1[m] % q) == 0)
                    {
                        flag = 1;
                        break;
                    }


                }
                if (flag == 0)
                {
                    Console.WriteLine($"Index of prime number {lst1[m]} is {m}");
                }

            }
            break;

        case 4:
            lstString.Sort();
            foreach (string str in lstString)
            {
                if (str.Contains('a'))
                {
                    Console.WriteLine(str);
                }
            }
            break;
        case 5:
            lstString.Sort();
            foreach (string str1 in lstString)
            {
                if (str1[0] == 'A' || str1[0] == 'M' || str1[0] == 'K')
                {
                    Console.WriteLine(str1);
                }
            }
            break;
        case 6:
            int count = 1;
            int flag1 = 0;
            for (int i = 0; i < lstString.Count -1; i++)
            {
                for(int j=i+1; j < lstString.Count; j++)
                {
                    if (lstString[i] == lstString[j])
                    {
                        count++;
                        flag1 = 1;
                        Console.WriteLine(lstString[i]);
                        Console.WriteLine($"appears {count} times");
                    }
                }
            }
            if (flag1 == 0)
            {
                Console.WriteLine("No repeated words");
            }

            break;
            

    }
    Console.WriteLine("Please enter y or Y to continue");
    continueExecution = Console.ReadLine();
    Console.Clear();
} while (continueExecution == "y" || continueExecution == "Y");

Console.ReadLine();


