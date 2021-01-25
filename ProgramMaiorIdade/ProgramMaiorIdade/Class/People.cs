using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramMaiorIdade.Class
{
    public static class PeopleExtensions
    {
        public static List<People> QuantidadeMaiorIdade(this List<People> peoples, People people)
        {
            if (peoples.Count > 0)
            {
                peoples = people.QtdMaiorDeIdade(peoples);
                return peoples;
            }
            return new List<People>();
        }
    }

    public class People
    {
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private string _nome { get; set; }

        public int Idade
        {
            get { return _idade; }
            set { _idade = value; }
        }

        private int _idade { get; set; }

        public int Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; }
        }

        private int _quantidade { get; set; }

        /// <summary>
        /// Contrutor Padrão
        /// </summary>
        public People()
        {

        }

        public List<People> QtdMaiorDeIdade(List<People> peoples)
        {
            try
            {
                if (peoples.Count > 0)
                {
                    peoples = peoples.Where(x => x._idade >= 18).ToList();
                    return peoples;
                }
                return new List<People>();
            }
            catch (Exception exp)
            {
                throw exp;
            }
        }
    }
}
