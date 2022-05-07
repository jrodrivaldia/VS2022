// See https://aka.ms/new-console-template for more information
using VS2022;

Console.WriteLine("Hello, jrvalencia!");
Console.WriteLine("==================");
//Date date1 = new Date(2022, 5, 4);
//Console.WriteLine(date1);
//try
//{
//    Console.WriteLine(new Date(2024, 2, 29));
//    Console.WriteLine(new Date(1974, 9, 23));
//    Console.WriteLine(new Date(1985, 11, 30));
//}
//catch (Exception error)
//{
//    Console.WriteLine(error.Message);
//}
Employee employee1 = new SalaryEmployee() {
    Id = 1010,
    FirstName = "Sandra",
    LastName = "Valencia",
    BirthDate = new Date(1990, 5, 23),
    HirigDate = new Date(2022, 1, 15),
    IsActive = true,
    Salary = 181543.45M
};
//Console.WriteLine(employee1);

Employee employee2 = new CommissionEmployee() {
    Id = 1011,
    FirstName = "Sandra",
    LastName = "Valencia",
    BirthDate = new Date(1990, 5, 23),
    HirigDate = new Date(2022, 1, 15),
    IsActive = true,
    Sales = 32000000M,
    CommissioPercentaje = 0.03f,
};
//Console.WriteLine(employee2);

Employee employee3 = new HourlyEmployee() {
    Id = 1012,
    FirstName = "lola",
    LastName = "Diaz",
    BirthDate = new Date(1982, 5, 23),
    HirigDate = new Date(2022, 1, 5),
    IsActive = true,
    HourValue = 12425.25M,
    Hours = 125.5F,
};
//Console.WriteLine(employee3);

Employee employee4 = new BaseCommissionEmployee() {
    Id = 1030,
    FirstName = "Raul",
    LastName = "Carlos",
    BirthDate = new Date(1989, 5, 23),
    HirigDate = new Date(2022, 1, 5),
    IsActive = true,
    Base = 860725.45M,
    Sales = 58000000,
    CommissioPercentaje = 0.015F,
};
//Console.WriteLine(employee4);
ICollection<Employee> employees = new List<Employee>()
{ employee1, employee2, employee3, employee4
};

decimal payroll = 0;

foreach (Employee employee in employees) 
{
    Console.WriteLine("=================================================================================");
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}

Console.WriteLine("                           =====================");
Console.WriteLine($"TOTAL                       : {$"{payroll:C2}",18}");
Console.WriteLine("                           =====================");

Console.WriteLine("=================================================================================");

Invoice invoice1 = new Invoice()
{
    Description = "Iphon 13",
    Id = 1,
    Price = 1500000,
    Quantity = 6,
};
Invoice invoice2 = new Invoice()
{
    Description = "Premium poss",
    Id = 2,
    Price = 3500000,
    Quantity = 17.5F,
};
Console.WriteLine("=================================================================================");
Console.WriteLine(invoice1);
Console.WriteLine(invoice2);

//employees.Add(employee1);
//employees.Add(employee2);
//employees.Add(employee3);
//employees.Add(employee4);

