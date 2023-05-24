using ChallengeApp;

var employee = new Employee("Michał", "Kowalik");
employee.AddGrade("Michał");
employee.AddGrade("500");
employee.AddGrade(8f);
employee.AddGrade(5);
employee.AddGrade(7.5);

var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

void SetSth(Statistics statistics)
{
    statistics = new Statistics();
}




