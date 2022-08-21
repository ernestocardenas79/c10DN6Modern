using System.Diagnostics;

namespace vocabulary
{
    public class Chapter04
    {

        public Chapter04()
        {
           Debug.WriteLine("Ejecutando codigo de Chapter04");
           double a = 4.5;
           double b = 2.5;

           double answer = Add(a,b);

           Console.WriteLine($"{a} + {b} = {answer}");
           Trace.WriteLine($"{typeof(Chapter04)} {a} + {b} = {answer}");
        }

       internal double Add(double a, double b)    {
            return a + b; 
       }
    }
}