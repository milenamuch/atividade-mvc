using System;
using Views;
using Controllers;

namespace ExercicioUm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int opt = 0;
            do 
            {
                Console.WriteLine("Digite a sua escolha: ");
                Console.WriteLine("[0] Sair");
                Console.WriteLine("[1] Inserir");
                Console.WriteLine("[2] Alterar");
                Console.WriteLine("[3] Excluir");
                Console.WriteLine("[4] Listar");
                Console.WriteLine("[5] Mostrar específico");

                opt = Convert.ToInt32(Console.ReadLine());

                switch (opt)
                {
                    case 0:
                        Console.WriteLine("Você saiu.");
                        break;
                    case 1:
                        ViewLeao.CriarLeao();
                        break;
                    case 2:
                        ViewLeao.AlterarLeao();
                        break;
                    case 3:
                        ViewLeao.RemoverLeao();
                        break;
                    case 4:
                        LeaoControllers.ListarLeao();
                        break;
                    case 5:
                        ViewLeao.GetLeao();
                        break;
                    default:
                        Console.WriteLine("Operação Inválida");
                        break;
                }
            } while (opt != 0);
        }
    }
}
