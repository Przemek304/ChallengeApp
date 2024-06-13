using ChallengeApp;


var employee = new Employee("Adam", "Kamizelich");
employee.AddGrades(2);
employee.AddGrades(6);
employee.AddGrades(2);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");


