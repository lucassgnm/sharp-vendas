using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpVendas
{
    class Conexao
    {
        SqlConnection conn;
        String fonte = @"Data Source=(LocalDB)\MSSQLLocalDB;
                        AttachDbFilename=C:\Users\lucas\source\repos\SharpVendas\SharpVendas\SharpVendas.mdf;
                        Integrated Security=True";

        public Conexao()
        {
            conn = new SqlConnection(fonte);
        }

        public SqlConnection Abrir() 
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }

            return conn;
        }

        public void Fechar()
        {
            conn.Close();
        }

    }
}
