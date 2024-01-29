using ChallangeApp;

Employee employee1 = new Employee("Adam", "Kowalski",25);
Employee employee2 = new Employee("Monika", "Kowalska",56);
Employee employee3 = new Employee("Zuzia", "Kowalska",54);

employee1.AddScore(1);
employee1.AddScore(2);
employee1.AddScore(3);

employee2.AddScore(4);
employee2.AddScore(5);
employee2.AddScore(6);

employee3.AddScore(7);
employee3.AddScore(8);
employee3.AddScore(9);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;

Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if(employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
        
    }
}

Console.WriteLine("Użytkownik z największą liczbą ocen to:" + employeeWithMaxResult.Name + " " + employeeWithMaxResult.SureName + employeeWithMaxResult.Age);





