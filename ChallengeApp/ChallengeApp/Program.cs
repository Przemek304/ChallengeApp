using ChallengeApp;

Employee user1 = new Employee("Adam", "Kowalski" , 25);
Employee user2 = new Employee("Damian", "Wiak", 23);
Employee user3 = new Employee("Darek", "Musiał", 21);

user1.AddScore(5);
user1.AddScore(9);
user1.AddScore(7);
user1.AddScore(6);
user1.AddScore(2);

user2.AddScore(3);
user2.AddScore(2);
user2.AddScore(3);
user2.AddScore(1);
user2.AddScore(9);

user3.AddScore(1);
user3.AddScore(9);
user3.AddScore(7);
user3.AddScore(7);
user3.AddScore(8);

List<Employee> users = new List<Employee>()
{
user1 ,user2 , user3

};

int maxResult = -1;

Employee userWithMaxResult = null;

foreach (var user in users)
{
    if(user.Result > maxResult)
    {
        userWithMaxResult = user;
    }
}

Console.WriteLine("Najlepszy Pracownik:");
Console.WriteLine("Imię : " + userWithMaxResult.Name);
Console.WriteLine("Nazwisko : " + userWithMaxResult.Surname);
Console.WriteLine("Wiek : " + userWithMaxResult.Age);
Console.WriteLine("Wynik : " + userWithMaxResult.Result);




