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
    class DAOcliente
    {
        public void inserirCliente(Cliente cliente)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "insert into cliente" +
                "(nome, cpf, rg, datanasc)" +
                "values (@nome, @cpf, @rg, @datanasc)");
            query.Connection = conn.Abrir();

            query.Parameters.Add("@nome", SqlDbType.VarChar).Value = cliente.nome;
            query.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cliente.cpf;
            query.Parameters.Add("@rg", SqlDbType.VarChar).Value = cliente.rg;
            query.Parameters.Add("@datanasc", SqlDbType.DateTime).Value = cliente.datanasc;
            query.ExecuteNonQuery();
            conn.Fechar();
        }

        public List<Cliente> listaTodosClientes()
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "select id, nome, cpf, rg, datanasc from cliente");
            query.Connection = conn.Abrir();
            using (SqlDataReader rs = query.ExecuteReader())
            {
                if (rs.HasRows)
                {
                    List<Cliente> clientes = new List<Cliente>();
                    while (rs.Read())
                    {
                        Cliente cl = new Cliente();
                        cl.id = rs.GetInt32(0);
                        cl.nome = rs.GetString(1);
                        cl.cpf = rs.GetString(2);
                        cl.rg = rs.GetString(3);
                        cl.datanasc = rs.GetDateTime(4);
                        clientes.Add(cl);
                    }
                    conn.Fechar();
                    return clientes;
                }
            }
            conn.Fechar();
            return null;
        }
        public void alterar(Cliente cl)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "update cliente set nome = @nome, " +
                "cpf = @cpf, " +
                "rg = @rg, " +
                "datanasc = @datanasc " +
                "where id = @id");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@nome", SqlDbType.VarChar).Value = cl.nome;
            query.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cl.cpf;
            query.Parameters.Add("@rg", SqlDbType.VarChar).Value = cl.rg;
            query.Parameters.Add("@datanasc", SqlDbType.DateTime).Value = cl .datanasc;
            query.Parameters.Add("@id", SqlDbType.Int).Value = cl.id;
            query.ExecuteNonQuery();
            conn.Fechar();
        }

        public void excluir(Cliente cl)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "delete from aluno where id = @id");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@id", SqlDbType.Int).Value = cl.id;
            query.ExecuteNonQuery();
            conn.Fechar();
        }
    }
}

