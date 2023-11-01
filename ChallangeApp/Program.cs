using HomeWork;

Console.WriteLine("Witamy w Programie XYZ do oceny pracownikow");
Console.WriteLine("============================================");
Console.WriteLine();
Console.WriteLine("Podaj ocene pracownika:");
var input = Console.ReadLine();
Employee worker1 = new Employee();
worker1.AddGrade(input);
while (true)
{
    Console.WriteLine("Podaj kolejna ocene lub 'q' aby wyjsc i wyswietlic statystyki");
    input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    worker1.AddGrade(input);
}
var statistics = worker1.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");