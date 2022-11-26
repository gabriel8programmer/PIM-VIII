using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Sistema_de_CRUD.Classes
{
    class PessoaDAO
    {
        private MySqlConnection connection;

        private MySqlConnection getConnection()
        {
            string strconnection = "datasource=localhost;username=root;password=Gb$32459878;database=data_souce";
            connection = new MySqlConnection(strconnection);
            return connection;
        }
        //RETORNA TRUE SE CONSEGUIR EXCLUIR DA BASE DE DADOS
        public bool exclua(Pessoa pessoa)
        {
            return false;
        }
        //RETORNA TRUE SE CONSEGUIR INSERIR DA BASE DE DADOS
        public bool insere(Pessoa pessoa)
        {
            return false;
        }
        //RETORNA TRUE SE CONSEGUIR ALTERNAR NA BASE DE DADOS
        public bool altere(Pessoa pessoa)
        {
            return false;
        }
        //RETORNA OS DADOS DA PESSOA QUE FOI CONSULTADA
        public Pessoa consulte(long cpf)
        {
            return new Pessoa();
        }
    }
}
