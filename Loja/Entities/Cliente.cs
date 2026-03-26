using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Entities
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime Nascimento { get; set; }

        public Cliente(string nome, string email, DateTime nascimento)
        {
            Nome = nome;
            Email = email;
            Nascimento = nascimento;
        }


    }
}
