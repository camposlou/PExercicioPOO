//Faça um programa que crie objetos filhos de uma classe pai Pessoa
//Os objetos filhos: terão o  nome de Aluno e Funcionários,

//A classe pai tem os seguintes atributos: 
//Nome
//Data de nasc
//Cpf

//Atributos classe Aluno:
//Registro
//data matricula

//Atributos classe funcionarios:
//Numero do Pis
//Salario
//Setor

//Criar todos os metodos set, get e ToString

using System;

namespace PExercicioPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("CADASTRO DO ALUNO");
            Console.WriteLine();
            Console.WriteLine("Digite a quantidade de aluno: ");
            int qtd_aluno = int.Parse(Console.ReadLine());
            Aluno[] aluno = new Aluno[qtd_aluno];

            for (int i = 0; i < qtd_aluno; i++)
            {
                Console.WriteLine("\nAluno : " + (i + 1) + " : ");
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Data de Nascimento: ");
                DateTime nascimento = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("CPF: ");
                string cpf = Console.ReadLine();
                Console.WriteLine("RA: ");
                string RA = (Console.ReadLine());
                Console.WriteLine("Data da Matricula: ");
                DateTime datamatricula = DateTime.Parse(Console.ReadLine());
                aluno[i] = new Aluno(nome, nascimento, cpf, RA, datamatricula);
                Console.WriteLine();

            }

            Console.WriteLine("CADASTRO DO FUNCIONÁRIO");
            Console.WriteLine();
            Console.WriteLine("Digite a quantidade de funcionários: ");
            int qtd = int.Parse(Console.ReadLine());
            Funcionario[] funcionario = new Funcionario[qtd];

            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine("\nFuncionáro: " + (i + 1) + "  ");
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Data de Nascimento: ");
                DateTime nascimento = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("CPF: ");
                string cpf = Console.ReadLine();
                Console.WriteLine("PIS: ");
                string pis = (Console.ReadLine());
                Console.WriteLine("Valor do Salario: ");
                float salario = float.Parse(Console.ReadLine());
                Console.WriteLine("Informe o Setor: ");
                string setor = Console.ReadLine();
                funcionario[i] = new Funcionario(nome, nascimento, cpf, pis, salario, setor);


            }

            for (int i = 0; i < qtd_aluno; i++)
            {
                Console.WriteLine(aluno[i]);
            }

            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine(funcionario[i]);
            }



        }


    }
}
