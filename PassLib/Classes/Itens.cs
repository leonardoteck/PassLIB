using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace PassLib
{
    class Itens
    {
        string categoria;
        string servico;
        string usuario;
        string senha;

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public string Servico
        {
            get { return servico; }
            set { servico = value; }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public Itens(string _categoria, string _servico, string _email,
            string _senha)
        {
            categoria = _categoria;
            servico = _servico;
            usuario = _email;
            senha = _senha;
        }
    }
}