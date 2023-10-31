using HomeWork;

Employee worker1 = new Employee("Andrzej", "Nowak", 23);

worker1.AddGrade("Adam");
worker1.AddGrade("6000");
worker1.AddGrade(2);
worker1.AddGrade(5);
worker1.AddGrade(6);

Console.WriteLine($"Max: {worker1.GetStatistics().Max}");
Console.WriteLine($"Min: {worker1.GetStatistics().Min}");
Console.WriteLine($"Average: {worker1.GetStatistics().Average:N2}");