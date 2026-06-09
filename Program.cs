namespace Class_0609_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(12, 27);
            Student s2 = new Student(60, 80);
            Student savg = s1 + s2;
            Console.WriteLine(savg.Mid);
            Console.WriteLine(savg.Final);
        }
    }
}