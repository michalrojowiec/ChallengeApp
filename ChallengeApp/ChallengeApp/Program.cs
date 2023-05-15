string name = "Ewa";
int age = 33;
string sex = "Female";

if (sex == "Female")
{
    if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa lat 33");
    } 
    else if (age <30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else if (age < 33)
    {
        Console.WriteLine("Kobieta poniżej 33 lat");
    }
    else if (age > 33)
    {
        Console.WriteLine("Kobieta powyżej 33 lat");
    }
}
else if (age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else if (age >= 18)
{
    Console.WriteLine("Pełnoletni mężczyzna");
}
    
