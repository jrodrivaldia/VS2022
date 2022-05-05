// See https://aka.ms/new-console-template for more information
using VS2022;

Console.WriteLine("Hello, jrvalencia!");
Console.WriteLine("==================");
/*Date date1 = new Date(2022, 5, 4);
Console.WriteLine(date1);*/
try
{
    Console.WriteLine(new Date(2024, 2, 29));
    Console.WriteLine(new Date(1974, 9, 23));
    Console.WriteLine(new Date(1985, 11, 30));
}
catch (Exception error)
{
    Console.WriteLine(error.Message);
}