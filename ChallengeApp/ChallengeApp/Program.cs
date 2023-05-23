using ChallengeApp;

var employee = new Employee("Michał", "Kowalik");
employee.AddGrade(5);
employee.AddGrade(8);
employee.AddGrade(4);

var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

void SetSth(Statistics statistics)
{
    statistics = new Statistics();
}




