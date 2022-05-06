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
Employee employee1 = new SalaryEmployee()
{
    Id = 1010,
    FirstName = "Sandra",
    LastName = "Valencia",
    BirthDate = new Date(1990, 5, 23),
    HirigDate = new Date(2022, 1, 15),
    IsActive = true,
    Salary = 181543.45M
};
Console.WriteLine(employee1);

Employee employee2 = new CommissionEmployee()
{
    Id = 1010,
    FirstName = "Sandra",
    LastName = "Valencia",
    BirthDate = new Date(1990, 5, 23),
    HirigDate = new Date(2022, 1, 15),
    IsActive = true,
    Sales = 32000000M,
    CommissioPercentaje = 0.03f,
};
Console.WriteLine(employee2);