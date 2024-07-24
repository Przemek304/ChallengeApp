using ChalleneApp;
using ChallengeApp;
using System.Runtime.CompilerServices;



Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
Console.WriteLine("============================================");
Console.WriteLine();


Console.WriteLine("Podaj Imię pracownika  ");
var name = Console.ReadLine();

Console.WriteLine();

Console.WriteLine("Podaj Nazwisko Pracownika   ");
var surename = Console.ReadLine();


var employee = new EmployeeInFile(name, surename);
employee.GradeAdded += EmployeeGradeAdded;


void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodoano nową ocenę");
}



while (true)
{
    Console.WriteLine($"Podaj kolejną ocenę dla {name} {surename}  ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
    

}
var statistics = employee.GetStatistics();

Console.WriteLine($" wyniki dla pracownika : {name} {surename}");
Console.WriteLine();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Averageletter: {statistics.AverageLetter}");