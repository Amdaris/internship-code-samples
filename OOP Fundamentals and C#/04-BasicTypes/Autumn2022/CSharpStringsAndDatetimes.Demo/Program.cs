// 1. String Formatting:

using CSharpStringsAndDatetimes.Demo;

string template = "Name={0,-20} Credit Limit={1,15:C}";

Console.WriteLine("String Formatting:");
Console.WriteLine(string.Format(template, "Mary", 500));
Console.WriteLine(string.Format(template, "Elizabeth", 20000));

double[] values = { 1603, 1794.68235, 15436.14 };

//  OUTPUT
//
//  $1,603.00   1.603E+003    1603.0000    1,603.000       16.03 %
//
//  $1,794.68   1.795E+003    1794.6824    1,794.682       17.95 %
//
// $15,436.14   1.544E+004   15436.1400   15,436.140      154.36 %
foreach (var value in values)
{
    Console.WriteLine(string.Format("{0,12:C2} {0,12:E3} {0,12:F4} {0,12:N3} {1,12:P2} \n", value, value / 10000));
}

// 2. String Interpolation:
Console.WriteLine();
Console.WriteLine("String Interpolation:");
string name = "John";
Console.WriteLine($"Hello, {name}! Today is {DateTime.Now.DayOfWeek}, it's {DateTime.Now:HH:mm} now.");

// 3. String Comparison:
Console.WriteLine();
Console.WriteLine("String Comparison:");
Console.WriteLine(string.Compare("Boston", "Austin")); // 1
Console.WriteLine(string.Compare("Boston", "Boston")); // 0
Console.WriteLine(string.Compare("Boston", "Chicago")); // -1

// 4. StringBuilder:
StringBuilderExamples.ShowExamples();

// 5. DateTime examples:
DateTimeExamples.ShowExamples();