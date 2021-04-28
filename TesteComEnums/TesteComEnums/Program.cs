using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteComEnums.Class;

namespace TesteComEnums
{
    public class Program
    {
        static void Main(string[] args)
        {
            string Descricao = "";
            Descricao = TiposDeEnums.Tipos.numero1.GetDescription();
            Console.WriteLine(Descricao);
        }
    }
}
