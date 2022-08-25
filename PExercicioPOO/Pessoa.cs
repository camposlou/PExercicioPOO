using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PExercicioPOO
{
    internal class Pessoa
    {
        public String Nome;
        DateTime DataNasc;
        String Cpf;
        
        public Pessoa()
        {

        }
        public Pessoa(string nome, DateTime dataNasc, string cpf)
        {
            Nome = nome;
            DataNasc = dataNasc;
            Cpf = cpf;
        }
        
        public void setNome()
        {
            Console.WriteLine("Informe o nome: ");
            this.Nome = Console.ReadLine();
        }
        public void getNome()
        {
            Console.WriteLine("\nNome: " + this.Nome);
        }
        public void setDatanasc()
        {
            Console.WriteLine("Informe a data do seu nascimento: ");
            DateTime DataNasc = DateTime.Parse(Console.ReadLine());
            this.DataNasc = DataNasc;
        }
        public void getDatanasc()
        {
            Console.WriteLine("\nData de nascimento: " + this.DataNasc.ToShortDateString());
        }
        public void setCpf()
        {
            Console.WriteLine("Informe o seu Cpf: ");
            this.Cpf = Console.ReadLine();
        }
        public void getCpf()
        {
            Console.WriteLine("\nCpf: " + this.Cpf);
        }

        public override string ToString()
        {
            return "\nNome: " + this.Nome + "\nDatanasc: " + this.DataNasc.ToLongDateString() +
                "\nCpf: " + Cpf;
        }

    }
}
