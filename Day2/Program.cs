namespace Day2;

public static class Program
{
    public static void Main()
    {
        Part1();
        Part2();
    }

    // A, X = rock = 1 point
    // B, Y = paper = 2 points
    // C, Z = scissors = 3 points
    private static void Part1()
    {
        var input = File.ReadAllLines("input.txt");
        var totalScore = 0;
        for (var i = 0; i < input.Length; i++)
        {
            var opponentPlay = input[i][0];
            var myPlay = input[i][2];

            switch (myPlay)
            {
                case 'X':
                    totalScore += 1;
                    if (opponentPlay == 'C')
                        totalScore += 6;
                    else if (opponentPlay == 'A')
                        totalScore += 3;
                    break;
                case 'Y':
                    totalScore += 2;
                    if (opponentPlay == 'A')
                        totalScore += 6;
                    else if (opponentPlay == 'B')
                        totalScore += 3;
                    break;
                case 'Z':
                    totalScore += 3;
                    if (opponentPlay == 'B')
                        totalScore += 6;
                    else if (opponentPlay == 'C')
                        totalScore += 3;
                    break;
            }

            if (opponentPlay == myPlay)
                totalScore += 3;
        }
        
        Console.WriteLine($"Part 1 - Total Score: {totalScore}");
    }
    
    // A = rock = 1 point, X = lose
    // B = paper = 2 points, Y = draw
    // C = scissors = 3 points, Z = win
    private static void Part2()
    {
        var input = File.ReadAllLines("input.txt");
        var totalScore = 0;
        for (var i = 0; i < input.Length; i++)
        {
            var opponentPlay = input[i][0];
            var myPlay = input[i][2];

            switch (myPlay)
            {
                case 'X':
                    switch (opponentPlay)
                    {
                        case 'A':
                            totalScore += 3;
                            break;
                        case 'B':
                            totalScore += 1;
                            break;
                        case 'C':
                            totalScore += 2;
                            break;
                    }
                    break;
                case 'Y':
                    totalScore += 3;
                    switch (opponentPlay)
                    {
                        case 'A':
                            totalScore += 1;
                            break;
                        case 'B':
                            totalScore += 2;
                            break;
                        case 'C':
                            totalScore += 3;
                            break;
                    }
                    break;
                case 'Z':
                    totalScore += 6;
                    switch (opponentPlay)
                    {
                        case 'A':
                            totalScore += 2;
                            break;
                        case 'B':
                            totalScore += 3;
                            break;
                        case 'C':
                            totalScore += 1;
                            break;
                    }
                    break;
            }
        }
        
        Console.WriteLine($"Part 2 - Total Score: {totalScore}");
    }
}