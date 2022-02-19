using System;
using System.Collections.Generic;
using System.Linq;

namespace Models
{
    public class Leao : Animal
    {
        public static List<Leao> Leoes = new List<Leao>();

        private static int ID = 0;
		
        public Leao(string nome) : base (++ID, nome){
            Leoes.Add(this);
        }

        public override string ToString()
        {
            return $"ID: {base.Id}\nNome: {base.Nome}";
        }

        public static Leao AlterarLeao(
            int id,
            string nome
        ) {
            Leao leao = Leao.Leoes.Find(leao => leao.Id == id);
            
            leao.Nome = nome;

            return leao;
        }

        public static Leao ListarEspecifico (int id)
        {  
            try
            {
                return (from leao in Leao.Leoes where leao.Id == id select leao).First();
            }
            catch
            {
                throw new Exception("Leão não encontrado");
            }
        }

        
    }
}