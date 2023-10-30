using HomeWork;

Employee worker1 = new Employee("Andrzej", "Nowak", 23);

worker1.AddScore(10.1f);
worker1.AddScore(20.2f);
worker1.AddScore(50.3f);

Console.WriteLine($"Max: {worker1.GetStatistics().Max}");
Console.WriteLine($"Min: {worker1.GetStatistics().Min}");
Console.WriteLine($"Average: {worker1.GetStatistics().Average}");