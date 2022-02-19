using Models;
using System;

namespace Controllers
{
    public class LeaoControllers
    {
        public static Leao CriarLeao(string nome) 
        {
            if (nome.Trim() == "") {
                throw new Exception("Nome não pode ser vazio");
            }

            return new Leao(nome);
        }
        public static Leao AlterarLeao(
            int id,
            string nome
        ) {
            GetLeao(id);
            return Leao.AlterarLeao(id, nome);
        }

        public static void ListarLeao()
        {
            foreach(Leao leoes in Leao.Leoes)
            {
                Console.WriteLine(leoes);
            }
        }

        public static void RemoverLeao(int id)
        {
            Leao leao = Leao.Leoes.Find(leao => leao.Id == id);

            Leao.Leoes.Remove(leao);
        }

        public static Leao GetLeao(int id)
        {
            return Leao.ListarEspecifico(id);
        }
    }
}