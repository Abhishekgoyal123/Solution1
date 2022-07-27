// See https://aka.ms/new-console-template for more information

string[] arr = new string[5];
Console.WriteLine("enter string");
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Console.ReadLine();
}

int[] arr1 = new int[5];
Console.WriteLine("enter integer array");
for (int i = 0; i < arr1.Length; i++)
{
    arr1[i] = Convert.ToInt32((Console.ReadLine()));
}

string continueExecution = "y";
do
{
    Console.WriteLine("1. Sort Array based on Length of each string");
    Console.WriteLine("2. Print index of even and odd number from the array");
    Console.WriteLine("3. Print index of prime numbers");
    Console.WriteLine("4. Search a Record in  Array");
    Console.WriteLine("5. Print string that starts from A M or K");
    Console.WriteLine("6. Find out count of repeated strings in an array");

    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                for (int k =i+1; k < arr.Length; k++)
                {
                    if (arr[i].Length > arr[k].Length)
                    {
                        var temp = arr[i];
                        arr[i] = arr[k];
                        arr[k] = temp;

                    }
                }
            }
   
            for (int j = 0; j < arr.Length; j++)
            {
                    Console.WriteLine(arr[j]);  
            }

            Console.WriteLine("-----------------Reverse Array-----------");

            for (int j=arr.Length-1;j>=0;j--)
            {
                Console.WriteLine(arr[j]);
            }
            break;
        case 2:

            for (var q = 0; q < arr1.Length; q++)
            {
                if (arr1[q] % 2 == 0)
                    Console.WriteLine($"Index of even number {arr1[q]} are:{q}");
                else
                    Console.WriteLine($"Index of odd number {arr1[q]} are:{q}");

            }
            break;
        case 3:
            for (int m = 0; m < arr1.Length; m++)
            {
                int flag = 0;
                if(arr1[m]==0 || arr1[m]==1)
                {
                    flag = 1;
                }
                for (int q = 2; q <= (arr1[m] / 2) ; q++)
                {
                    if ((arr1[m] % q) == 0)
                    {
                        flag = 1;
                        break;
                    }


                }
                if (flag == 0)
                {
                    Console.WriteLine($"Index of prime number {arr1[m]} is {m}");
                }

            }
            break;

        case 4:
            Array.Sort(arr);
            foreach (string str in arr)
            {
                if(str.Contains('a') || str.Contains('A'))
                {
                    Console.WriteLine(str);
                }
            }
            break;
        case 5:
            Array.Sort(arr);
            foreach (string str1 in arr)
            {
                
                if (str1[0]=='A' || str1[0] == 'M' || str1[0] == 'K')
                {
                  Console.WriteLine(str1);
                }
            }
            break;
        case 6:
            int count = 1;
            int flag1 = 0;
            for (int t = 0; t < arr.Length; t++)
            {
                for (int r=t+1 ; r < arr.Length; r++)
                {
                    if (arr[t] ==arr[r])
                    {

                        flag1 = 1;
                        count++;
                        Console.WriteLine($"Word {arr[t]} appears {count} times");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Word {arr[t]} appears {count} times");
                        break;
                    }


                }
            }
            /*if (flag1 == 0)
            {
                Console.WriteLine("No repeated words");
            }*/

            break;

    }
    Console.WriteLine("Please enter y or Y to continue");
    continueExecution = Console.ReadLine();
    Console.Clear();
}while (continueExecution == "y" || continueExecution == "Y");

Console.ReadLine();


