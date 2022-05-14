using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;



namespace ConsoleApp1
{
    internal class Morador
    {
        static long CPF, TEL;
        static double Renda;
        static byte Dependentes;
        static string Nome, Endereco;

        public static void setCPF(long c)
        {

            if (c > 10000000000)
                CPF = c;

        }
        public static long getCPF()
        {
            return CPF;
        }
        public static void setTEL(long t)
        {

            if (t > 10000000000)
                TEL = t;

        }
        public static long getTEL()
        {
            return TEL;
        }
        public static void setRenda(double r)
        {

            if (r < 0)
                Renda = r;

        }
        public static double getRenda()
        {
            return Renda;
        }

        public static void setDependentes(byte d)
        {

            if (d < 0)
                Dependentes = d;

        }
        public static byte getDependentes()
        {
            return Dependentes;
        }
        public static void setEndereco(string e)
        {

            Endereco = e;

        }
        public static string getEndereco()
        {
            return Endereco;
        }
        public static void setNome(string n)
        {

            Nome = n;

        }
        public static string getNome()
        {
            return Nome;
        }

    }
}
