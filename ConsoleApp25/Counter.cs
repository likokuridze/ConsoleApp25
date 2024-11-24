namespace ConsoleApp25
{
    internal class Counter
    {
        static int Count = 0;

        public Counter()
        {
            Count++;
        }

        public static int GetCount()
        {
            return Count;
        }

        public static void ResetCount()
        {
            Count = 0;
        }
    }
}

