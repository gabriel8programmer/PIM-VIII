using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_CRUD.Controller
{
    class Pessoa
    {
        protected int id;
        public string nome;
        public long cpf;
        public Endereco endereco;
        public Telefone[] telefones;
    }
}
