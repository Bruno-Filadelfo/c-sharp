using System.ComponentModel;
using System.Globalization;

namespace SaidadeDados {
    internal class Program {
        static void Main(string[] args) {

            //char genero = 'M';
            //int idade1 = 28;
            //double saldo1 = 10.85487;
            //string nome1 = "Bruno";

            //Dados Básicos
            //Console.Write("Bom dia! ");
            //Console.WriteLine("Boa noite!");
            //Console.WriteLine("-------------------");
            //Console.WriteLine(genero);
            //Console.WriteLine(idade1);
            //Console.WriteLine(saldo1);
            //Console.WriteLine(nome1);
            //Console.WriteLine(saldo1.ToString("F2"));
            //Console.WriteLine(saldo1.ToString("F4"));
            //Console.WriteLine(saldo1.ToString("F4",CultureInfo.InvariantCulture));



            //Placeholders 

            //int idade2 = 28;
            //double saldo2 = 900.000; 
            //string nome2 = "Bruno";
            //Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome2, idade2, saldo2);

            //Concatenação 

            int idade3 = 28;
            double saldo3 = 198.78571;
            string nome = "Bruno";
            Console.WriteLine(nome + " tem " + idade3 + " anos e tem saldo igual a " + saldo3.ToString("F2", CultureInfo.InvariantCulture) + " reais ");


            //Interpolação

            //int idade4 = 28;
            //double saldo4 = 10.0000;
            //string nome4 = "Bruno";
            //Console.WriteLine($"{nome4} tem {idade4} anos e o saldo é {saldo4:F2} reais");

        }
    }
}
