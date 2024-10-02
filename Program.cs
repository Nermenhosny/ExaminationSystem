using System.Diagnostics;

namespace Exam02
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            Subject sub1 = new Subject(1,"Signals");
            sub1.CreateExam();
            Console.Clear();
            Console.WriteLine("Do You Want To Start The Exam(y | n): ");
            string ans=Console.ReadLine();
           
            while (ans.ToLower() != "y" && ans.ToLower()!= "n")
            {
                Console.WriteLine("Please Enter (y | n)");
                ans = Console.ReadLine();
            
            }
            Console.Clear();
            if (ans.ToLower() == "y")
            {
                Stopwatch sw = Stopwatch.StartNew();
                sw.Start();
                sub1.exam.showExam();
                Console.WriteLine($"The Elapsed Time = {sw.Elapsed}");
            }
            
        }
    }
}