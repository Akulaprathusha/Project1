namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Logging flog = new FileLog();
            Person p = new Person(flog);
            p.Id = 1;
            p.Name = "Test";
            p.LogM();
        }
    }
}
