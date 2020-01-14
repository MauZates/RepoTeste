using System;
using System.Collections.Generic;
using System.Text;

namespace ParamsAndRefOut
{
    class Calculator
    {
        #region Params

        //public static int Sum(params int[] numbers)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        sum += numbers[i];
        //    }
        //    return sum;
        //}

        #endregion
        #region Ref
        //public static void Triple(ref int x)
        //{
        //    x = x * 3;
        //}
        #endregion

        #region Out

        public static void Triple(int origin, out int result)
        {
            result = origin * 3;
        }

        #endregion
    }
}
