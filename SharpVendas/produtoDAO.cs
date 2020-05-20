using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SharpVendas.models_controllers
{
    class DAOproduto
    {
        public void inserirProduto(Produto produto)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "insert into produto" +
                "(descricao, valor, qtde)" +
                "values (@descricao, @valor, @qtde)");
            query.Connection = conn.Abrir();

            query.Parameters.Add("@descricao", SqlDbType.VarChar).Value = produto.descricao;
            query.Parameters.Add("@valor", SqlDbType.Real).Value = produto.valor;
            query.Parameters.Add("@qtde", SqlDbType.Int).Value = produto.qtde;
            query.ExecuteNonQuery();
            conn.Fechar();
        }

        public List<Produto> listaTodosProdutos()
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "select id, descricao, valor, qtde from produto");
            query.Connection = conn.Abrir();
            using (SqlDataReader rs = query.ExecuteReader())
            {
                if (rs.HasRows)
                {
                    List<Produto> produtos = new List<Produto>();
                    while (rs.Read())
                    {
                        Produto p1 = new Produto();
                        p1.id = rs.GetInt32(0);
                        p1.descricao = rs.GetString(1);
                        p1.valor = rs.GetFloat(2);
                        p1.qtde = rs.GetInt32(3);
                        produtos.Add(p1);
                    }
                    conn.Fechar();
                    return produtos;
                }
            }
            conn.Fechar();
            return null;
        }

        public List<Produto> listaTodosProdutosLike(String pesq)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "select id, descricao, valor, qtde from produto where descricao like '%" + pesq + "%'");
            query.Connection = conn.Abrir();
            using (SqlDataReader rs = query.ExecuteReader())
            {
                if (rs.HasRows)
                {
                    List<Produto> produtos = new List<Produto>();
                    while (rs.Read())
                    {
                        Produto p1 = new Produto();
                        p1.id = rs.GetInt32(0);
                        p1.descricao = rs.GetString(1);
                        p1.valor = rs.GetFloat(2);
                        p1.qtde = rs.GetInt32(3);
                        produtos.Add(p1);
                    }
                    conn.Fechar();
                    return produtos;
                }
            }
            conn.Fechar();
            return null;
        }

        public void alterar(Produto p1)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "update produto set descricao = @descricao, " +
                "valor = @valor, " +
                "qtde = @qtde " +
                "where id = @id");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@descricao", SqlDbType.VarChar).Value = p1.descricao;
            query.Parameters.Add("@valor", SqlDbType.Real).Value = p1.valor;
            query.Parameters.Add("@qtde", SqlDbType.Int).Value = p1.qtde;
            query.Parameters.Add("@id", SqlDbType.Int).Value = p1.id;
            query.ExecuteNonQuery();
            conn.Fechar();
        }

        public void excluir(Produto p1)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "delete from produto where id = @id");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@id", SqlDbType.Int).Value = p1.id;
            query.ExecuteNonQuery();
            conn.Fechar();
        }
    }
}

