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
    class itemVendaDAO
    {
        public void inserirItemVenda(List<ItemVenda> iv)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "insert into itemvenda" +
                "(idvenda, idproduto, qtde, valorun, valortotal)" +
                "values (@idvenda, @idproduto, @qtde, @valorun, @valortotal)");
            query.Connection = conn.Abrir();

            for (int i = 0; i < iv.Count; i++)
            {
                query.Parameters.Clear();
                query.Parameters.Add("@idvenda", SqlDbType.Int).Value = iv[i].idvenda;
                query.Parameters.Add("@idproduto", SqlDbType.Int).Value = iv[i].idproduto;
                query.Parameters.Add("@qtde", SqlDbType.Int).Value = iv[i].qtde;
                query.Parameters.Add("@valorun", SqlDbType.Real).Value = iv[i].valorun;
                query.Parameters.Add("@valortotal", SqlDbType.Real).Value = iv[i].valortotal;
                query.ExecuteNonQuery();
            }

            
            conn.Fechar();
        }

        public List<UltimaVenda> listaUltimaVenda(int id)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "select itemvenda.idproduto, produto.descricao, itemvenda.qtde, itemvenda.valorun, itemvenda.valortotal " +
                "from cliente join venda on cliente.id = venda.idcliente join vendedor on venda.idvendedor = vendedor.id " +
                "join itemvenda on itemvenda.idvenda = venda.id " +
                "join produto on itemvenda.idproduto = produto.id " +
                "where venda.id = @id");
            query.Parameters.Add("@id", SqlDbType.Int).Value = id;
            query.Connection = conn.Abrir();
            using (SqlDataReader rs = query.ExecuteReader())
            {
                if (rs.HasRows)
                {
                    List<UltimaVenda> ultimav = new List<UltimaVenda>();
                    while (rs.Read())
                    {
                        UltimaVenda d = new UltimaVenda();
                        d.idproduto = rs.GetInt32(0);
                        d.descricao = rs.GetString(1);
                        d.qtde = rs.GetInt32(2);
                        d.valorun = rs.GetFloat(3);
                        d.valortotal = rs.GetFloat(4);
                        ultimav.Add(d);
                    }
                    conn.Fechar();
                    return ultimav;
                }
            }
            conn.Fechar();
            return null;
        }
    }
}
