using ChallengeApp;

var user1 = new Employee("Michał", "Kowalik", "32");
var user2 = new Employee("Justyna", "Paczka", "24");
var user3 = new Employee("Wojtek", "Radzińaki", "30");


user1.AddScore(2);
user1.AddScore(8);
user1.AddScore(7);
user1.AddScore(3);
user1.AddScore(6);

user2.AddScore(4);
user2.AddScore(8);
user2.AddScore(7);
user2.AddScore(9);
user2.AddScore(5);

user3.AddScore(2);
user3.AddScore(6);
user3.AddScore(5);
user3.AddScore(7);
user3.AddScore(3);

int MaxResult = -1;
Employee userWithMaxResult = null;

List<Employee> users = new List<Employee>()
{
    user1,user2, user3
};

foreach (var user in users)
{
    if (user.Result > MaxResult)
    {
        userWithMaxResult = user1;
        MaxResult = user1.Result;
    }
    else if (user2.Result > MaxResult)
    {
        userWithMaxResult = user2;
        MaxResult = user2.Result;
    }
    else if (user3.Result > MaxResult)
    {
        userWithMaxResult = user3;
        MaxResult = user3.Result;
    }
}

Console.WriteLine("Najwyższa ocena wynosi: " + MaxResult + " punkty");
Console.WriteLine("Najwyższa ocena została zdobyta przez pracownika: " + userWithMaxResult.Name + " " + userWithMaxResult.Surname + ", " + userWithMaxResult.Age + " lata");
