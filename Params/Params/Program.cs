using System;

namespace ParamsAndRefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Params

            //int s1 = Calculator.Sum(1, 3);
            //int s2 = Calculator.Sum(1, 3, 33, 66, 3);
            //Console.WriteLine(s1);
            //Console.WriteLine(s2);

            #endregion

            #region Ref

            //int a = 10;
            //Calculator.Triple(ref a);
            //Console.WriteLine(a);

            #endregion

            #region Out

            int a = 10;
            int triple;
            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);

            #endregion
        }
    }
}
