using System.Runtime.InteropServices;

static class Export
{
    [UnmanagedCallersOnly(EntryPoint = "Method")]
    public static int CalculateData()
    {
        return 42;
    }
} 