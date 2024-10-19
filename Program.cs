using System.ComponentModel;

namespace MethodOverloadingPracticeTest
{
   public class Source
    {
        public int Add(int a, int b, int c)    //add method using int
        {
            return a + b + c;
        }
        public double Add(double a, double b, double c)  //Add method using double
        { 
            return a + b + c;
        }   
        static void Main(string[] args)                 //main method
        {
           Source source = new Source();
            int num = int.Parse(Console.ReadLine());    //taking num to how many times we have to run the loop
             
            for (int i = 0; i < num; i++) // for loop iterate the num
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine(source.Add(a, b, c));
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                double z = double.Parse(Console.ReadLine());
                Console.WriteLine(source.Add(x, y, z));
            }

        }
    }
}

