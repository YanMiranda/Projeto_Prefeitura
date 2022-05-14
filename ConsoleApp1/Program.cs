using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static void main(String[] args)
        {

            for (int i = 0; i <= 2; i++)
            {
                Morador MRD = new Morador();

                Console.WriteLine("Qual o nome do morador:");
                MRD.setNome() = Console.ReadLine();

                Console.WriteLine("Qual o endereço do morador:");
                MRD.endereço = Console.ReadLine();

                Console.WriteLine("Qual o tel do morador:");
                MRD.tel = double.Parse(Console.ReadLine());

                Console.WriteLine("Qual o numero de dependentes do morador:");
                MRD.dependententes = int.Parse(Console.ReadLine());

                Console.WriteLine("Qual a renda do morador:");
                MRD.renda = int.Parse(Console.ReadLine());

                Console.WriteLine("Qual o CPF do morador:");
                MRD.CPF = double.Parse(Console.ReadLine());

                foreach (DictionaryEntry IMP in morador)


            }


        }

    }
}
