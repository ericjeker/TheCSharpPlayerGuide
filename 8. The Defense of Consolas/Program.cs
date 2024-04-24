Console.Title = "The Defense of Consolas";

// Game Loop
while (true)
{
    Console.WriteLine("Consolas is attacked! We need your help to defend it!\n");

    // Ask the user where the next attack is going to happen
    Console.Write("Next attack at row: ");
    var targetRow = int.Parse(Console.ReadLine() ?? "0");
    Console.Write($"{"column: ", 20}");
    var targetColumn = int.Parse(Console.ReadLine() ?? "0");

    if (targetRow < 1 || targetRow > 8 || targetColumn < 1 || targetColumn > 8)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Target location is outside the city!");
        return;
    }

    // Display the deployment locations in different colors
    Console.WriteLine("\nThe deployment locations are:");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"{"Team Blue:",-12} ({targetRow}, {targetColumn - 1})");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"{"Team Red:",-12} ({targetRow + 1}, {targetColumn})");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{"Team Green:",-12} ({targetRow}, {targetColumn + 1})");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"{"Team Yellow:",-12} ({targetRow - 1}, {targetColumn})");
    // Reset the color
    Console.ForegroundColor = ConsoleColor.White;

    // Play a sound to indicate the end of the game
    Console.Beep();

    // Ask the user if they want to play another game
    Console.Write("\nAnother game? (y/N): ");
    var anotherGame = Console.ReadLine();
    if (anotherGame?.ToLower() != "y")
    {
        Console.WriteLine("Thank you for saving Consolas!");
        break;
    }

    Console.Clear();
}
