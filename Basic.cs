18-02-2025


using System;
class Basic
{
    static void Main()
    {
        Console.WriteLine("jee Line 1");
        Console.WriteLine("jee Line 2");
        Console.WriteLine("Jeev Line 3");
    }
}

Old C# (.NET Framework / .NET Core ≤5) la:
❌ using System; illa na error varum

But .NET 6+ la:
✅ Compiler itself System namespace-a auto add pannidum

🧠 What really happens behind the scenes

Compiler internally ipdi treat pannum 👇

global using System;



class Basic
{
    static void Main()
    {
        System.Console.WriteLine("jee Line 1");
        System.Console.WriteLine("jee Line 2");
        System.Console.WriteLine("Jeev Line 3");
    }
}


“In .NET 6 and above, System is included automatically using implicit global usings,
 so Console.WriteLine works even without using System;.”


class Basic
{
    static void Main()
    {
        Console.WriteLine("jee Line 1");
        Console.WriteLine("jee Line 2");
        Console.WriteLine("Jeev Line 3");
    }
}


