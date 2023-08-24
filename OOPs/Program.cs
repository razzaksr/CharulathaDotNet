using System.Reflection.Metadata;
using Heritance;

Console.WriteLine((int)Process.HLD);
Console.WriteLine((int)Process.Review);

foreach (var item in Enum.GetNames(typeof(Process)))
{
    Console.WriteLine(item);
}
foreach (var item in Enum.GetValues(typeof(Process)))
{
    Console.WriteLine((int)item);
}