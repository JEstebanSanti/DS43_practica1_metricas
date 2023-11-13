using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estandaresymetricas
{
    internal class ConectionMysql: Conection
    {
        private MySqlConnection connection;
        private string stringConnection;
        public ConectionMysql() 
        { 
            
        }
    }
}
