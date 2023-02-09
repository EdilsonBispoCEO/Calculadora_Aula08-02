using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
namespace Calculadora
{
    public class Program
    {
        static void Main(string[] args)
        {
            double valor1 = 0.0;
            double valor2 = 0.0;
            string opcao;


            for (opcao = ""; opcao != "parar";)
            {
                Console.WriteLine("Digite o Primeiro Valor: ");
                valor1 = Convert.ToDouble(Console.ReadLine()); Console.WriteLine("Digite o Segundo Valor: ");
                valor2 = Convert.ToDouble(Console.ReadLine()); Console.WriteLine("Qual operação Matematica voce ira usar?");

                Console.WriteLine("    1- Soma ");
                Console.WriteLine("    2-Subtração ");
                Console.WriteLine("    3-Divisão");
                Console.WriteLine("    4-Multiplicação");
                Console.WriteLine("    5-Nenhuma das opções, to saindo"); Console.WriteLine("Digite sua opção");


                switch (Console.ReadLine())
                {

                    case "1":

                        Console.WriteLine("A soma é : " + (valor1 + valor2));
                        break;

                    case "2":

                        Console.WriteLine("A Subtraao é  :" + (valor1 - valor2));
                        break;


                    case "3":
                        if (valor1 >= valor2)

                            Console.WriteLine("A divisão é : " + (valor1 / valor2));
                        else Console.WriteLine("Operação invalida");
                        break;


                    case "4":


                        Console.WriteLine("A multiplicação : " + (valor1 * valor2));
                        break;

                    case "5":

                        Console.WriteLine("Nenhuma das opções, só estou vendo");
                        break;



                }

                Console.WriteLine("Quer continuar?");
                opcao = Console.ReadLine();


            }
        }
    }
}



/*double valor1 = 0;
double valor2 = 0;
string nome = "Edy";
double valor3 = 4.5;
bool verdadde = false;
int valor4 = 2;
double divis = 0;
string asterisco = "*"; */
