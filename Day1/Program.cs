namespace Day1;

public static class Program
{
    public static void Main()
    {
        Part1();
        Part2();
    }
    
    private static void Part1()
    {
        var input = File.ReadAllText("input.txt");
        var inventories = input.Split("\n\n");
        var previousTotal = 0;
        var position = 0; // Position of elf carrying most calories

        for (var i = 0; i < inventories.Length; i++)
        {
            var total = 0;
            var foods = inventories[i].Split('\n');
    
            for (var j = 0; j < foods.Length; j++)
            {
                if (foods[j] == "")
                    break;
                total += int.Parse(foods[j]);
            }

            if (total <= previousTotal) continue;
            
            previousTotal = total;
            position = i;
        }

        Console.WriteLine($"Elf with the highest caloric count at index: {position}, with {previousTotal} calories.");
    }

    private static void Part2()
    {
        var input = File.ReadAllText("input.txt");
        var inventories = input.Split("\n\n");
        var first = 0;
        var second = 0;
        var third = 0;

        for (var i = 0; i < inventories.Length; i++)
        {
            var total = 0;
            var foods = inventories[i].Split('\n');
    
            for (var j = 0; j < foods.Length; j++)
            {
                if (foods[j] == "")
                    break;
                total += int.Parse(foods[j]);
            }

            if (total > first)
                first = total;
            else if (total > second)
                second = total;
            else if (total > third)
                third = total;
        }

        Console.WriteLine($"Elves with the highest caloric count: {first}, {second}, {third} - Total: {first + second + third}");
    }
}