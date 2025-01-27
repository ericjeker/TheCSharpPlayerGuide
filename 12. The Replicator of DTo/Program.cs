// See https://aka.ms/new-console-template for more information

int[] numbers = new int[5];
int[] numbers2 = new int[5];

void WriteArray<T>(T[] array)
{
    foreach (var item in array)
    {
        Console.Write(item + " ");
    }
}

Console.WriteLine("Please enter 5 numbers: ");

for (int i = 0; i < 5; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < numbers.Length; i++)
{
    numbers2[i] = numbers[i];
}

Console.Write("\nFirst array: ");
WriteArray(numbers);

Console.Write("\nSecond array: ");
WriteArray(numbers2);