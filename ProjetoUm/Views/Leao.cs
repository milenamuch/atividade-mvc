using System;
using Controllers;
using Models;

namespace Views
{
    public class ViewLeao
    {
        public static void CriarLeao()
        {
            Console.WriteLine("Digite o nome do leão: ");
            string name = Console.ReadLine();

            try{
                Leao leao = Controllers.LeaoControllers.CriarLeao(name);

                Console.WriteLine(leao);
            } catch (Exception err) {
                Console.WriteLine(err.Message);
            }
        }
        public static void AlterarLeao()
        {
            Console.WriteLine("Digite o id do leão: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o nome do leão: ");
            string name = Console.ReadLine();

            try{
                Leao leao = Controllers.LeaoControllers.AlterarLeao(id, name);

                Console.WriteLine(leao);
            } catch (Exception err) {
                Console.WriteLine(err.Message);
            }
        }

        public static void RemoverLeao()
        {
            Console.WriteLine("Digite o id do leão: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Controllers.LeaoControllers.RemoverLeao(id);
        }

        public static void GetLeao()
        {
            Console.WriteLine("Digite o id do leão: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Models.Leao leao = Controllers.LeaoControllers.GetLeao(id);
            Console.WriteLine(leao);
        }

    }
}
