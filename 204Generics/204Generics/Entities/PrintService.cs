using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _204Generics.Entities
{
    #region PrimeiraVezEstudada    
    //public class PrintService
    //{
    //    private int[] _valores = new int[10];
    //    private int _count = 0;

    //    public void AddValue(int value)
    //    {
    //        if (_count == 10)
    //        {
    //            throw new InvalidOperationException("PrintService is full");
    //        }
    //        else
    //        {
    //            _valores[_count] = value;
    //            _count++;
    //        }
    //    }

    //    public int First()
    //    {
    //        if (_count == 0)
    //        {
    //            throw new ArgumentNullException("Print Service is empty");
    //        }
    //        return _valores[0];
    //    }

    //    public void Print()
    //    {
    //        Console.Write("[");
    //        for (int i = 0; i < _count - 1; i++)
    //        {
    //            Console.Write(_valores[i] + ", ");
    //        }

    //        if (_count > 0)
    //        {
    //            Console.Write(_valores[_count - 1]);
    //        }
    //        Console.WriteLine("]");
    //    }
    //}
    #endregion

    #region SegundaVezEstudada
    public class PrintService<FinalType>
    {
        private FinalType[] _valores = new FinalType[10];
        private int _count = 0;

        public void AddValue(FinalType value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("PrintService is full");
            }
            else
            {
                _valores[_count] = value;
                _count++;
            }
        }

        public FinalType First()
        {
            if (_count == 0)
            {
                throw new ArgumentNullException("Print Service is empty");
            }
            return _valores[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write(_valores[i] + ", ");
            }

            if (_count > 0)
            {
                Console.Write(_valores[_count - 1]);
            }
            Console.WriteLine("]");
        }
    }
    #endregion
}
