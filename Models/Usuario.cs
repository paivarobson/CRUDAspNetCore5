using System.Collections.Generic;
using System.Linq;

namespace CRUDAspNetCore5.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        private static List<Usuario> listagem = new List<Usuario>();
        public static IQueryable<Usuario> Listagem
        { 
            get 
            {
                return listagem.AsQueryable();
            }
        }

        static Usuario()
        {
            Usuario.listagem.Add(
                new Usuario {Id = 1, Nome = "Fulano", Email = "fulano@email.com"});
            Usuario.listagem.Add(
                new Usuario {Id = 2, Nome = "Sicrano", Email = "sicrano@email.com"});
            Usuario.listagem.Add(
                new Usuario {Id = 3, Nome = "Beltrano", Email = "beltrano@email.com"});
            Usuario.listagem.Add(
                new Usuario {Id = 4, Nome = "João", Email = "joao@email.com"});
            Usuario.listagem.Add(
                new Usuario {Id = 5, Nome = "Maria", Email = "maria@email.com"});
        }
        
    }
}