Console.WriteLine("Number of chocolates eggs:");
var numberOfEggs = Console.ReadLine();
const int numberOfSisters = 4;

if (string.IsNullOrEmpty(numberOfEggs))
{
    Console.WriteLine("Please enter a valid number of eggs.");
    return;
}

Console.WriteLine($"Each sister gets {int.Parse(numberOfEggs) / numberOfSisters} eggs, the Duckbear gets {int.Parse(numberOfEggs) % numberOfSisters} eggs.");
