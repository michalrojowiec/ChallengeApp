using ChallengeApp;

var employee = new Employee("Michał", "Kowalik");
employee.AddGrade("Michał");
employee.AddGrade("500");
employee.AddGrade(8f);
employee.AddGrade(5);
employee.AddGrade(7.5);

var statistics = employee.GetStatistics();
var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");





