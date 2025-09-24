using System;

namespace Atv_trimestral
{
    class Paciente
    {
        public string nome;
        public string cpf;
        public int idade;
        public bool preferencial;

        public void AdicionarDados()
        {
            //teste para commit

            Console.Write("Digite o nome do paciente: ");
            nome = Console.ReadLine();
            Console.Write("Digite o CPF do paciente: ");
            cpf = Console.ReadLine();
            Console.Write("Digite a Idade do paciente: ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("\nExemplos de Preferenciais:");
            Console.WriteLine("\nGravidas");
            Console.WriteLine("\nIdosos(60+)");
            Console.WriteLine("\nPessoas Com Deficiencia (PCD)");
            Console.Write("\nO paciente é Preferencial? (s/n): ");
            preferencial = Console.ReadLine().ToLower() == "s";
        }

        public void AlterarDados()
        {
            Console.WriteLine("Alterando dados:");
            AdicionarDados();
        }

        public void MostrarDados()
        {
            Console.WriteLine($"Nome: {nome}, CPF: {cpf}, Idade: {idade}, Preferencial: {(preferencial ? "Sim" : "Não")}");
        }
    }

}
