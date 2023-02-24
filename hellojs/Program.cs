using System.Runtime.InteropServices;

Console.WriteLine($"Get following int from function: {Imports.get_int()}");
Console.WriteLine($"Get following double from function: {Imports.get_double()}");
Console.WriteLine($"Get following string from function: {Imports.get_string()}");
Imports.call_no_parameters();
Imports.alert("This is JS alert");

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
}
