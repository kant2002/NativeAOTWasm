using System.Runtime.InteropServices;

Console.WriteLine($"Get following int from function: {Imports.get_int()}");
Console.WriteLine($"Get following double from function: {Imports.get_double()}");
Console.WriteLine($"Get following string from function: {Imports.get_string()}");
Imports.call_no_parameters();
Imports.alert("This is JS alert");
int refVal = 22;
Imports.int_parameter(out var outVal, ref refVal);
Console.WriteLine($"Get following string from int_parameter: {outVal} and {refVal}. Expected 100 and 39");
Imports.bool_parameter(out var trueVal, out var falseVal);
Console.WriteLine($"Get following string from bool_parameter: true = {trueVal} and false = {falseVal}.");

static class Imports
{
    [DllImport("*")]
    public static extern void call_no_parameters();

    [DllImport("*")]
    public static extern void alert(string message);

    // If JS returns double value, then it would be trimmed to nearest number with lowest absolute value.
    [DllImport("*")]
    public static extern int get_int();

    [DllImport("*")]
    public static extern double get_double();

    [DllImport("*")]
    [return: MarshalAs(UnmanagedType.LPUTF8Str)]
    public static extern string get_string();

    [DllImport("*")]
    public static extern void int_parameter(out int intOut, ref int intRef);

    [DllImport("*")]
    public static extern void bool_parameter(out bool trueValue, out bool falseValue);
}
