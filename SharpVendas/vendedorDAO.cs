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
    class DAOvendedor
    {
        public void inserirVendedor(Vendedor vendedor)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "insert into vendedor" +
                "(nome, cpf, dataadimis)" +
                "values (@nome, @cpf, @dataadimis)");
            query.Connection = conn.Abrir();

            query.Parameters.Add("@nome", SqlDbType.VarChar).Value = vendedor.nome;
            query.Parameters.Add("@cpf", SqlDbType.VarChar).Value = vendedor.cpf;
            query.Parameters.Add("@dataadimis", SqlDbType.DateTime).Value = vendedor.dataadimis;
            query.ExecuteNonQuery();
            conn.Fechar();
        }

        public List<Vendedor> listaTodosVendedores()
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "select id, nome, cpf, dataadimis from vendedor");
            query.Connection = conn.Abrir();
            using (SqlDataReader rs = query.ExecuteReader())
            {
                if (rs.HasRows)
                {
                    List<Vendedor> vendedores = new List<Vendedor>();
                    while (rs.Read())
                    {
                        Vendedor v1 = new Vendedor();
                        v1.id = rs.GetInt32(0);
                        v1.nome = rs.GetString(1);
                        v1.cpf = rs.GetString(2);
                        v1.dataadimis = rs.GetDateTime(3);
                        vendedores.Add(v1);
                    }
                    conn.Fechar();
                    return vendedores;
                }
            }
            conn.Fechar();
            return null;
        }

        public List<Vendedor> listaTodosVendedoresLike(String pesq)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "select id, nome, cpf, dataadimis from vendedor where nome like '%" + pesq +"%'");
            query.Connection = conn.Abrir();
            using (SqlDataReader rs = query.ExecuteReader())
            {
                if (rs.HasRows)
                {
                    List<Vendedor> vendedores = new List<Vendedor>();
                    while (rs.Read())
                    {
                        Vendedor v1 = new Vendedor();
                        v1.id = rs.GetInt32(0);
                        v1.nome = rs.GetString(1);
                        v1.cpf = rs.GetString(2);
                        v1.dataadimis = rs.GetDateTime(3);
                        vendedores.Add(v1);
                    }
                    conn.Fechar();
                    return vendedores;
                }
            }
            conn.Fechar();
            return null;
        }

        public void alterar(Vendedor v1)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "update vendedor set nome = @nome, " +
                "cpf = @cpf, " +
                "dataadimis = @dataadimis " +
                "where id = @id");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@nome", SqlDbType.VarChar).Value = v1.nome;
            query.Parameters.Add("@cpf", SqlDbType.VarChar).Value = v1.cpf;
            query.Parameters.Add("@dataadmis", SqlDbType.DateTime).Value = v1 .dataadimis;
            query.Parameters.Add("@id", SqlDbType.Int).Value = v1.id;
            query.ExecuteNonQuery();
            conn.Fechar();
        }

        public void excluir(Vendedor v1)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "delete from vendedor where id = @id");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@id", SqlDbType.Int).Value = v1.id;
            query.ExecuteNonQuery();
            conn.Fechar();
        }
    }
}

