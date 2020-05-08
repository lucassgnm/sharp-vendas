using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpVendas.models_controllers
{
    class DAOcliente
    {
        public void inserirCliente(Cliente cliente)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "insert into cliente");
        }
    }
}
