using System;

namespace HelloDelegate
{
    class Program
    {
        /// <summary>
        /// 这几种委托方式是最原始的，以后可以用action和func
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //第一种
            MyDele dele = new MyDele(M1);

            //第二种
            MyDele2 dele2 = new MyDele2(Add);
            int res = dele2(100, 200);

            //第三种
            MyDele3<int> dele3 = new MyDele3<int>(Add);
            int res2 = dele3(200, 400);

        }
         
        static void M1()
        {
            Console.WriteLine("M1 is called");
        }
        static int Add(int x ,int y)
        {
            return x + y;
        }
        //第一种：是无返回值委托
        delegate void MyDele();
        //第二种：有返回值，并且带参数委托
        delegate int MyDele2(int a,int b);
        //第三种：是泛型的委托,带返回值类型和参数类型
        delegate T MyDele3<T>(T a, T b);
    }
}
