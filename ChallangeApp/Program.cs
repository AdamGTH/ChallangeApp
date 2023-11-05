using HomeWork;

Console.WriteLine("Witamy w Programie XYZ do oceny pracownikow");
Console.WriteLine("============================================");
Console.WriteLine();

Employee worker1 = new Employee();
try
{
    Employee worker2 = new Employee("Adam", "KOwalczyk", 22, "men");
}
catch(Exception ex)
{
    Console.WriteLine(ex.ToString());
}

Console.WriteLine("Podaj ocene pracownika:");
var input = Console.ReadLine();
worker1.AddGrade(input);

while (true)
{
    Console.WriteLine("Podaj kolejna ocene lub 'q' aby wyjsc i wyswietlic statystyki");
    input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        worker1.AddGrade(input);
    }
    catch(Exception ex)
    {
        Console.WriteLine($"Exeption catched: {ex.Message}");
    }
    
}
var statistics = worker1.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
