// See https://aka.ms/new-console-template for more information

int[] arr = new int[5];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

for(int i = 0; i < arr.Length-1; i++)
{
    if(arr[i] == 5)
    {
        int temp =arr[i];
        arr[i] = arr[i + 1];
        arr[i+1] = temp;

    }
}

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}




