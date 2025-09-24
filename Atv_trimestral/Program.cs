using System;

namespace Atv_trimestral
{

    class Program
    {
        static Paciente[] fila = new Paciente[15];
        static int total = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao sistema Hospitalar v1.6");
            bool sair = false;

            while (!sair)
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("1 - Cadastrar paciente");
                Console.WriteLine("2 - Listar pacientes");
                Console.WriteLine("3 - Alterar paciente");
                Console.WriteLine("4 - Atender paciente");
                Console.WriteLine("q - Sair");
                Console.Write("Escolha: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        AdicionarNaFila();
                        break;
                    case "2":
                        ListarFila();
                        break;
                    case "3":
                        AlterarPaciente();
                        break;
                    case "4":
                        AtenderPaciente();
                        break;
                    case "q":
                        sair = true;
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opsie opção inválida! \n tente novamente");
                        break;
                }
            }
        }

        static void AdicionarNaFila()
        {
            if (total >= fila.Length)
            {
                Console.WriteLine("Fila cheia! atenda pacientes e tente novamente");
                return;
            }

            Paciente novo = new Paciente();
            novo.AdicionarDados();

            if (novo.preferencial)
            {
                int pos = 0;
                while (pos < total && fila[pos].preferencial)
                {
                    pos++;
                }
                for (int i = total; i > pos; i--)
                {
                    fila[i] = fila[i - 1];
                }
                fila[pos] = novo;
            }
            else
            {
                fila[total] = novo;
            }

            total++;
            Console.WriteLine("Paciente adicionado a fila!");
        }

        static void ListarFila()
        {
            if (total == 0)
            {
                Console.WriteLine("Nenhum paciente encontrado na fila.");
                return;
            }

            for (int i = 0; i < total; i++)
            {
                Console.Write($"{i + 1} - ");
                fila[i].MostrarDados();
            }
        }

        static void AlterarPaciente()
        {
            Console.Write("Digite o número do paciente que quer alterar: ");
            int indice = int.Parse(Console.ReadLine()) - 1;
            if (indice >= 0 && indice < total)
            {
                fila[indice].AlterarDados();
                Console.WriteLine("Dados atualizados!");
            }
            else
            {
                Console.WriteLine("Número inválido!");
            }
        }

        static void AtenderPaciente()
        {
            if (total == 0)
            {
                Console.WriteLine("Nenhum paciente encontrado na fila!");
                return;
            }

            Console.WriteLine("Atendendo paciente, por favor espere");
            fila[0].MostrarDados();

            for (int i = 0; i < total - 1; i++)
            {
                fila[i] = fila[i + 1];
            }
            fila[total - 1] = null;
            total--;

            Console.WriteLine("Paciente atendido com sucesso! :)");
        }
    }
}


