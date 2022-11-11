using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Tecnoo.Entities
{
    public static class Banco
    {
        //propriedades
        private const string servidor = "localhost";
        private const string nomedb = "tecnoodb";
        private const string usuario = "root";
        private const string senha = "";
        private const string porta = "3307";

        //String de conexão
        public static string strConn = $"server={servidor};database={nomedb};User Id={usuario};password={senha};port={porta}";

    }

}
