// See https://aka.ms/new-console-template for more information

using Classes__Structs__and_Records;

//Employee e = new Employee
//{
//    FirstName = "Manpreet",
//    LastName = "Singh",
//    EmployeeId = 10,
//    StartDate = new DateOnly(2023, 9, 21)
//};

// You can use constructors and object initialization together as well.
Employee e = new Employee("Manpreet", "Singh", 45)
{
    StartDate = new DateOnly(2023, 9, 21)
};

Console.WriteLine($"Hello, World! from {e.FirstName} {e.LastName} on {e.StartDate}");

var age = new Age
{ 
    BirthDate = new DateTime(1993, 10, 17),
    YearsOld = 30
};

Console.WriteLine($"Age is {age.BirthDate} and years is {age.YearsOld}");