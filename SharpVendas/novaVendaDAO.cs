using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpVendas.models_controllers;

namespace SharpVendas
{
    class novaVendaDAO
    {
        public void inserirVenda(Venda venda)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "insert into venda" +
                "(idcliente, idvendedor, datavenda, total)" +
                "values (@idcliente, @idvendedor, @datavenda, @total)");
            query.Connection = conn.Abrir();

            query.Parameters.Add("@idcliente", SqlDbType.Int).Value = venda.idcliente;
            query.Parameters.Add("@idvendedor", SqlDbType.Int).Value = venda.idvendedor;
            query.Parameters.Add("@datavenda", SqlDbType.DateTime).Value = venda.datavenda;
            query.Parameters.Add("@total", SqlDbType.Real).Value = venda.total;
            query.ExecuteNonQuery();
            conn.Fechar();
        }

        public int getLastId()
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "select v.id " +
                "from venda v " +
                "where v.id = (select max(v2.id) " +
                "from venda v2)");
            query.Connection = conn.Abrir();
            int res = 0;
            using (SqlDataReader rs = query.ExecuteReader())
            {
                if (rs.HasRows)
                {
                    while (rs.Read())
                    {
                        res = rs.GetInt32(0);
                    }
                    conn.Fechar();
                    return res;
                }
            }
            conn.Fechar();
            return 0000;
        }


    }
}
