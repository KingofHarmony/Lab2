///Andy Mateo
///CPS 3330 section 3 Lab2
using static System.Console;
namespace Lab2_Main
{
    class Program
    {
        static void Main(string[] args)
        {

            int a;
            int b;
            int? c;
            WriteLine("Enter Integer for 'a' then press enter: ");
            a = Convert.ToInt32(Console.ReadLine());

            WriteLine("Enter Integer for 'a' then press enter: ");
            b = Convert.ToInt32(Console.ReadLine());
            //Asks user for a third imput, if null then catch exception
            try
            {
                WriteLine("Enter Integer for 'c' then press enter, or simply press enter to only use previous 2: ");
                c = Convert.ToInt32(Console.ReadLine());
            }
            //if exception detected, make int? c = null
            catch (FormatException)
            {
                c = null;
            }
            //if only 2 inputs
            if(c!= null)
            {
                Lab2.Lab2.averageNum(a, b,c);
            }
            //if 3 inputs
            else
            {
                Lab2.Lab2.averageNum(a, b);
            }
        }
    }
}