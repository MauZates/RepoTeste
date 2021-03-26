using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _204Generics.Entities
{
    #region PrimeiraVezEstudada    
    //public class PrintService<T>
    //{
    //    private T[] _values = new T[10];
    //    private int _count = 0;

    //    public void AddValue(T value)
    //    {
    //        if (_count == 10)
    //        {
    //            throw new InvalidOperationException("PrintService is full");
    //        }

    //        _values[_count] = value;
    //        _count++;
    //    }

    //    public T First()
    //    {
    //        if (_count == 0)
    //        {
    //            throw new InvalidOperationException("PrintService is empty");
    //        }

    //        return _values[0];
    //    }

    //    public void Print()
    //    {
    //        Console.Write("[");
    //        for (int i = 0; i < _count - 1; i++)
    //        {
    //            Console.Write(_values[i] + ", ");
    //        }

    //        if (_count > 0)
    //        {
    //            Console.Write(_values[_count - 1]);
    //        }
    //        Console.WriteLine("]");
    //    }
    //}
    #endregion

    public class PrintService
    {
        private int[] _valores = new int[10];
        private int _count = 0;

        public void AddValue(int value)
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

        public int First()
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
}
