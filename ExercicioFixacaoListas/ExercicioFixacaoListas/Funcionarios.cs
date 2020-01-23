using System.Globalization;

namespace ExercicioFixacaoListas
{
    /// <summary>
    /// Classe interna de Funcionarios
    /// </summary>
    internal class Funcionarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        /// <summary>
        /// Construtor Padrao
        /// </summary>
        public Funcionarios()
        {

        }

        /// <summary>
        /// Construtor dos funcionários
        /// </summary>
        /// <param name="id">Id dos Funcionarios</param>
        /// <param name="nome">Nome dos Funcionarios</param>
        /// <param name="salario">Salario Funcionarios</param>
        public Funcionarios(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        /// <summary>
        /// Método responsável por incrementar o salario de acordo com a
        /// porcentagem informada
        /// </summary>
        /// <param name="porcentagem"> Porcentagem informada </param>
        public void IncrementarSalario(double porcentagem)
        {
            Salario += Salario * porcentagem / 100.00;
        }

        /// <summary>
        /// Retorno da mensagem por string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Id
                + ", "
                + Nome
                + ", "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}