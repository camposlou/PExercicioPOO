using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PExercicioPOO
{
    internal class Aluno : Pessoa
    {
        String RA;
        DateTime DataMatricula;

        public Aluno()
        {

        }
        public Aluno(string nome, DateTime datanasc, string Cpf, string RA, DateTime datamatricula) :
           base(nome, datanasc, Cpf)
        {
            RA = RA;
            DataMatricula = datamatricula;

        }
        public void setRA()
        {
            Console.WriteLine("Informe o seu RA: ");
            this.RA = Console.ReadLine();
        }
        public void getRA()
        {
            Console.WriteLine("\nRA: " + RA);
        }
        public void setDataMatricula()
        {
            Console.WriteLine("Informe a data da sua Matricula: ");
            DateTime DataMatricula = DateTime.Parse(Console.ReadLine());
            this.DataMatricula = DataMatricula;
        }
        public void getDataMatricula()
        {
            Console.WriteLine("\nData da Matricula: " + this.DataMatricula.ToShortDateString());
        }
       
        public  string ImprimirCadastro()
        {
            return base.ToString() + "\nRegistro: " + RA + "\nDatamatricula: "+ DataMatricula;
        }
    }
}


