public class Program
{
    public static void Main()
    {
        Console.WriteLine("test c#");        
        ThreadStart threadStart = new ThreadStart(() => { Console.WriteLine("test thread..."); });
        Thread thread = new Thread(threadStart);
        thread.Start();
    }
}


