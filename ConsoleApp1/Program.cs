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
        public static void Main(String[] args)
        {

            char flag;
            HashSet<Morador> M1 = new HashSet<Morador>();
            int i = 0;
            do
            {
                
                Morador MRD = new Morador();

                Console.WriteLine("Qual o nome do morador:");
                MRD.SetNome(Console.ReadLine());

                Console.WriteLine("Qual o endereço do morador:");
                MRD.SetEndereco(Console.ReadLine());

                Console.WriteLine("Qual o tel do morador:");
                MRD.SetTel(long.Parse(Console.ReadLine()));

                Console.WriteLine("Qual o numero de dependentes do morador:");
                MRD.SetDependentes(byte.Parse(Console.ReadLine()));

                Console.WriteLine("Qual a renda do morador:");
                MRD.SetRenda(double.Parse(Console.ReadLine()));

                Console.WriteLine("Qual o CPF do morador:");
                MRD.SetCpf(long.Parse(Console.ReadLine()));

                if(MRD.GetRenda() <= 1212)
                {
                    M1.Add(MRD);
                } else {
                    Console.WriteLine("O Morador não é apto a participar do programa. Possui renda maior que" +
                        " 1 salário minimo");
                }

                Console.WriteLine("Deseja inserir outro morador? (S/N)");
                flag = char.Parse(Console.ReadLine());


            } while (flag == 's' || flag == 'S');

            Console.WriteLine("Insira o cpf para pesquisa: ");
            long busca = long.Parse(Console.ReadLine());

            foreach(Morador m in M1)
            {
                if (busca == m.GetCpf())
                    Console.WriteLine(m.ImprimeTudo());
                else
                    Console.WriteLine("N existe o morador");
            }
            Console.ReadKey();


        }

    }
}
