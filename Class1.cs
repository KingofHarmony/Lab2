///Andy Mateo
///CPS 3330 section 3 Lab2
namespace Lab2
{
    public class Lab2
    {
        public static void averageNum(int a, int b)
        {
            Console.WriteLine("Provided integers: {0:N4} and {1:N4}, the average is {2:N5}", a, b, Convert.ToDouble(a + b) / 2);
        }
        public static void averageNum(int a, int b, int? c)
        {
            Console.WriteLine("Provided integers: {0:N4} and {1:N4} and {2:N4}, the average is {3:N5}", a, b, c, Convert.ToDouble(a + b + c) / 3);
        }
    }
}