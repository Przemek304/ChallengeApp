var name = "Ewa";
var gender = "female";
var Age = 35;


if (gender == "female" && Age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && Age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (gender == "male" && Age > 18)
{
    Console.WriteLine("Niepełnoletni Męszczyzna");
}
 else 
{
    Console.WriteLine("Nie spełnia żadnego warnku");
}