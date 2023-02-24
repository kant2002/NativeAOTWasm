using System.Runtime.InteropServices;

Imports.test();

static class Imports
{
    [DllImport("*")]
    public static extern void test();
}
