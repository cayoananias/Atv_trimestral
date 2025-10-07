using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv_timestral1._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paciente[] fila = new Paciente[15];
            int total = 0;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("=======================================");
            Console.WriteLine("Bem vindo ao sistema Hospitalar v2.7");
            Console.WriteLine("=======================================");
            bool sair = false;

            while (!sair)
            {
                Console.WriteLine("----------Menu----------");
                Console.WriteLine("1 - Cadastrar paciente");
                Console.WriteLine("2 - Listar pacientes");
                Console.WriteLine("3 - Alterar paciente");
                Console.WriteLine("4 - Atender paciente");
                Console.WriteLine("q - Sair");
                Console.WriteLine("=======================================");
                Console.Write("Escolha: ");
                string opcao = Console.ReadLine().ToLower();

                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        if (total >= fila.Length)
                        {
                            Console.WriteLine("Fila cheia! por favor atenda pacientes e tente novamente");
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
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        if (total == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Nenhum paciente encontrado na fila.");
                        }

                        for (int i = 0; i < total; i++)
                        {
                            Console.Clear();
                            Console.Write($"{i + 1} - ");
                            fila[i].MostrarDados();
                        }
                        break;
                    case "3":
                        Console.Clear();
                        if(total==0){
                            Console.Clear();
                            Console.WriteLine("Não há pacientes para alterar\nadicione um e tente novamente");
                            break;
                        }
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
                        break;
                    case "4":
                        Console.Clear();
                        if (total == 0)
                        {
                            Console.WriteLine("Nenhum paciente encontrado na fila!");
                        }
                        else
                        {
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
                            break;
                        
                    case "q":
                        Console.Clear();
                        sair = true;
                        Console.WriteLine("Adeus....");
                        break;
                    default:
                        Console.WriteLine("Opsie opção inválida! \n tente novamente");
                        Console.Clear();
                        break;
                }
            }
        }
    }
}









