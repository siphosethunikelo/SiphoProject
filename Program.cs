namespace SiphoProject1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("enter DOB");
            string DOB = Console.ReadLine();

            string Usr1 = name.Substring(0, 2);
            string Usr2 = DOB.Substring(0, 3);
            string uname = Usr1 + Usr2;

            Console.WriteLine("your unique code is" + " " + uname);

            Console.WriteLine("enter your marks");
            int marks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter term marks");
            int termMarks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter monthly test marks");
            int monthlyMarks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter  weekly test marks ");
            int weeklyMarks = Convert.ToInt32(Console.ReadLine());

            double MonMarks = marks * 30 / 100;
            double WeeklyMarks = marks * 20 / 100;
            double TermMarks = marks * 50 / 100;
            double finalMarks = MonMarks + WeeklyMarks + TermMarks;

            if (finalMarks >= 80 && termMarks >= 35)
            {
                Console.WriteLine("dear" + " " + name + " " + "unique Username is" + uname + " " + "You have successfuly completed the course and passed with symbol A");
            }
            else if (finalMarks >= 70 && termMarks >= 35)
            {
                Console.WriteLine("dear" + " " + name + " " + "unique Username is" + uname + " " + "You have successfuly completed the course and passed with symbol B");
            }
            else if (finalMarks >= 60 && termMarks >= 35)
            {
                Console.WriteLine("dear" + " " + name + " " + "unique Username is" + uname + " " + "You have successfuly completed the course and passed with symbol C");

            }
            else if (finalMarks >= 60 && termMarks <= 35)
            {
                Console.WriteLine("dear" + " " + name + " " + "unique Username is" + uname + " " + "You have completed the course and you qualify for refered exam ");
            }
            else if (finalMarks < 60 && termMarks < 35)
            {
                Console.WriteLine("dear" + " " + name + " " + "unique Username is" + uname + " " + "You have failed the course ");
            }


            //Console.WriteLine("Hello, World!");
        }
    }
}