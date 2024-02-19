using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDelegate2
{
    class Program
    {
        static void Main(string[] args)
        {
            //无返回值，无参数可以用action
            Action action = new Action(M1);
            action();

            //无返回值，有参数可以用action
            Action<string,string> action2 = new Action<string, string>(SayHello);
            action2("Tim","Tom");
            //var action2 = new Action<string, string>(SayHello);
            //action2("Tim", "Tom");

            //有返回值，有参数可以用action，第一个是返回值类型，第二个和第三个是传入参数类型
            var func = new Func<double, double, double>(Mul);
            double res = func(3.0, 4.0);
            Console.WriteLine(res);
        }

        static void M1()
        {
            Console.WriteLine("M1 is called");
        }

        static void SayHello(string name1,string name2)
        {
            Console.WriteLine($"Hello,{name1}and{name2}!");
        }

        static double Mul(double x,double y)
        {
            return x + y;
        }
    }
}
