using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula199ExercicioInterface.Entities;
using Aula199ExercicioInterface.Services;

namespace Aula199ExercicioInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            //Número do Contrato    
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());

            //Data do contrato
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            //Valor do Contrato
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            //Carregando os itens informados na tela na classe de contrato
            Contract myContract = new Contract(contractNumber, contractDate, contractValue);
            
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Console.Write("Amazon = 1 || Paypal = 2: ");
            bool isAmazon = int.Parse(Console.ReadLine()) == 1 ? true : false;

            if (isAmazon)
            {
                ContractService contractService = new ContractService(new AmazonService());
                contractService.ProcessContractPaypal(myContract, months);
            }
            else
            {
                ContractService contractService = new ContractService(new PaypalService());
                contractService.ProcessContractPaypal(myContract, months);
            }


            Console.WriteLine("Installments:");
            foreach (Installment installment in myContract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
