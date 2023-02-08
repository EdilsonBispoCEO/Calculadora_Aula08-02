using System;
using System.Collections.Generic;
using System.Linq;
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
            string opcao = ""; 
            
            
            Console.WriteLine("Digite o Primeiro Valor: ");
            valor1 = Convert.ToDouble(Console.ReadLine()); Console.WriteLine("Digite o Segundo Valor: ");
            valor2 = Convert.ToDouble(Console.ReadLine()); Console.WriteLine("Qual operação Matematica voce ira usar?");

            Console.WriteLine("    1- Soma ");
            Console.WriteLine("    2-Subtração ");
            Console.WriteLine("    3-Divisão");
            Console.WriteLine("    4-Multiplicação");
            Console.WriteLine("    5-Nenhuma das opções, to saindo"); Console.WriteLine("Digite sua opção");


            opcao = (Console.ReadLine()); if (opcao == "1")
            {
                Console.WriteLine("A soma é : " + (valor1 + valor2));
            }

            else if (opcao == "2")
            {
                Console.WriteLine("A Subtraao é  :" + (valor1 - valor2));
            }

            else if (opcao == "3")
            {
                Console.WriteLine("A divisão é : " + (valor1 / valor2));
            }

            else if (opcao == "4")
            {

                Console.WriteLine("A multiplicação : " + (valor1 * valor2));
            }

            else if (opcao == "5")
            {
                Console.WriteLine("Nenhuma das opções, to saindo");
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
