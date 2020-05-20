using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpVendas
{
    class itemVendaDAO
    {
        public void inserirItemVenda(ItemVenda iv)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "insert into itemvenda" +
                "(idvenda, idproduto, qtde, valorun, valortotal)" +
                "values (@idvenda, @idproduto, @qtde, @valorun, @valortotal)");
            query.Connection = conn.Abrir();

            query.Parameters.Add("@idvenda", SqlDbType.Int).Value = iv.idvenda;
            query.Parameters.Add("@idproduto", SqlDbType.Int).Value = iv.idproduto;
            query.Parameters.Add("@qtde", SqlDbType.Int).Value = iv.qtde;
            query.Parameters.Add("@valorun", SqlDbType.Real).Value = iv.valorun;
            query.Parameters.Add("@valortotal", SqlDbType.Real).Value = iv.valortotal;
            query.ExecuteNonQuery();
            conn.Fechar();
        }
    }
}
