using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PExercicioPOO
{
    internal class Funcionario : Pessoa
    {
        String PIS;
        float Salario;
        String Setor;

        public Funcionario()
        {

        }
        public Funcionario(string nome, DateTime datanasc, string Cpf, string PIS, float salario, string setor)
           : base(nome, datanasc, Cpf)

        {
            PIS = PIS;
            Salario = salario;
            Setor = setor;
        }
        public void setPIS()
        {
            Console.WriteLine("Informe o PIS: ");
            this.PIS = Console.ReadLine();
        }
        public void getPIS()
        {
            Console.WriteLine("\nPIS: " + this.PIS);
        }
        public void setSalario()
        {
            Console.WriteLine("Informe o seu salario: ");
            float Salario = float.Parse(Console.ReadLine());
            this.Salario = Salario;
        }
        public void getSalario()
        {
            Console.WriteLine("\nSalario: " + this.Salario);
        }
        public void setSetor()
        {
            Console.WriteLine("Informe seu setor: ");
            this.Setor = Console.ReadLine();
        }
        public void getSetor()
        {
            Console.WriteLine("\nSetor: " + this.Setor);
        }


       
        public override string ToString()
        {
            return base.ToString()+ "\nPIS: " + PIS + "\nSalário: " + Salario + "\nSetor: " + Setor;
        }


    }
}
