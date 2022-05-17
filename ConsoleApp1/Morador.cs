﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;



namespace ConsoleApp1
{
    internal class Morador
    {
        private string nome;
        private long cpf; 
        private long tel;
        private double renda; 
        private byte dependentes; 
        private string endereco;
        public string GetNome()
        {
            return nome;
        }
        public void SetNome(string n)
        {
            nome = n;
        }
        public long GetCpf()
        {
            return cpf;
        }
        public void SetCpf(long c)
        {
            cpf = c;
        }
        public long GetTel()
        {
            return tel;
        }
        public void SetTel(long t)
        {

            if (t > 10000000000)
                tel = t;

        }
        public double GetRenda()
        {
            return renda;
        }
        public void SetRenda(double r)
        {
            if (r > 0)
                renda = r;
        }
        public byte GetDependentes()
        {
            return dependentes;
        }
        public void SetDependentes(byte d)
        {
            if (d > 0)
                dependentes = d;
        }
        public string GetEndereco()
        {
            return endereco;
        }
        public void SetEndereco(string e)
        {

            endereco = e;

        }

        public string ImprimeTudo()
        {
            return "Morador: "+cpf+",Nome:"+ nome+",Tel:"+tel+",Endereço:"+endereco+
                ",Dependentes:"+dependentes+",Renda:"+renda;
        }

    }
}
