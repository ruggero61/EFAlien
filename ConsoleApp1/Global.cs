using System.Runtime.CompilerServices;

namespace ConsoleApp1;

public class Global
{
    [ModuleInitializer]
    public static void Init()
    {
        Console.WriteLine($"database connection string is {GlobalVars.connectionToDataBase}"); 
    }
}