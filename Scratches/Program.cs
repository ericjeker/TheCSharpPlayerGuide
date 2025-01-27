// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

int[] scores = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int smallestScore = int.MaxValue;

for (int i = 0; i < scores.Length; i++)
{
    int score = scores[i];
    if (score < smallestScore)
    {
        smallestScore = score;
    }
}

Console.WriteLine("The smallest score is {0}", smallestScore);