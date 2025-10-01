using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv_timestral1._8
{
    class Paciente
    {
        public string nome;
        public string cpf;
        public int idade;
        public bool preferencial;
        public string resposta;
        public int aux;
        public void AdicionarDados()
        {
            //teste para commit

            Console.Write("Digite o nome do paciente: ");
            nome = Console.ReadLine();
            Console.Clear();
            Console.Write("Digite o CPF do paciente: ");
            cpf = Console.ReadLine();
            Console.Clear();
            Console.Write("Digite a Idade do paciente: ");
            idade = int.Parse(Console.ReadLine());
            Console.Clear();
            while (aux == 0)
            {
                Console.WriteLine("\nExemplos de Preferenciais:");
                Console.WriteLine("\nGravidas");
                Console.WriteLine("\nIdosos(60+)");
                Console.WriteLine("\nPessoas Com Deficiencia (PCD)");
                Console.Write("\nO paciente é Preferencial? (s/n): ");
                resposta = Console.ReadLine();
                if (resposta == "s" || resposta == "S")
                {
                    preferencial = true;
                    aux = 1;
                }
                else if (resposta == "n" || resposta == "N")
                {
                    preferencial = false;
                    aux = 1;
                }
                else
                {
                    Console.WriteLine("Digite uma opção valida por favor");
                }
            }
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
