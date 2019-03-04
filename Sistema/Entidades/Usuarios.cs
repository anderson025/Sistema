using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    class Usuarios
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }

        public Usuarios()
        {

        }

        public Usuarios(string usuario, string senha)
        {
            Usuario = usuario;
            Senha = senha;
        }
    }
}
