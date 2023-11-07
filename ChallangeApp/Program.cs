using ChallangeApp;
using HomeWork;

Console.WriteLine("Witamy w Programie XYZ do oceny pracownikow");
Console.WriteLine("============================================");
Console.WriteLine();

EmployeeInFile Emp = new EmployeeInFile("Adam", "Kowalski");
Emp.AddGrade(10);
Emp.AddGrade(10);
Emp.AddGrade(40);
Emp.AddGrade(40);

var statistics = Emp.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

//Console.WriteLine("Podaj ocene pracownika:");
//Employee worker1 = new Employee("Adam", "Kowal");
//var input = Console.ReadLine();
//worker1.AddGrade(input);

//while (true)
//{
//    Console.WriteLine("Podaj kolejna ocene lub 'q' aby wyjsc i wyswietlic statystyki");
//    input = Console.ReadLine();
//    if (input == "q")
//    {
//        break;
//    }
//    try
//    {
//        worker1.AddGrade(input);
//    }
//    catch(Exception ex)
//    {
//        Console.WriteLine($"Exeption catched: {ex.Message}");
//    }

//}
//var statistics = work.GetStatistics();
//Console.WriteLine($"Average: {statistics.Average:N2}");
//Console.WriteLine($"Min: {statistics.Min}");
//Console.WriteLine($"Max: {statistics.Max}");
