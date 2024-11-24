// See https://aka.ms/new-console-template for more information

namespace ConsoleApp25;

  class Program
{
    static void Main(string[] args)
    {
        Counter c1 = new Counter();
        int count1 = Counter.GetCount();
        Console.WriteLine($"პირველი ობიექტის შემდეგ: {count1}");

        Counter c2 = new Counter();
        int count2 = Counter.GetCount();
        Console.WriteLine($"მეორე ობიექტის შემდეგ: {count2}");

        Counter.ResetCount();
        int resetCount = Counter.GetCount();
        Console.WriteLine($"განულების შემდეგ: {resetCount}");
    }
}
