// See https://aka.ms/new-console-template for more information

string[] arr = new string[] { "Mahesh", "Tejas", "Mukesh", "Satish", "Vivek", "Vinay", "Sandeep", "Nandu", "Anil", "Abhay", "Jaywant", "Shyam", "Tushar", "Sanjay", "Sharad", "Vijay", "Abhay", "Vilas" };
Array.Sort(arr);
for (int i = 0; i < arr.Length; i++)
{
    for (int k = i+1; k < arr.Length; k++)
    {
        if (arr[i].Length > arr[k].Length)
        {
            var temp = arr[i];
            arr[i] = arr[k];
            arr[k] = temp;

        }
    }
}



for (int s=0;s<arr.Length;s++)
{
    Console.WriteLine(arr[s]);
}