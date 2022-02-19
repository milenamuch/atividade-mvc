using System;

namespace Models
{
    public class Animal
    {
        public int Id {get;set;}
		public string Nome {get;set;}

        public Animal(
        	int id,
        	string nome
		)
		{
        	this.Id = id;
        	this.Nome = nome;
    	}
    }
}