using System;
using SIDAF.Model;
using System.Data.SqlClient;
using System.Data;

namespace SIDAF.DAL
{
    public sealed class ClienteDAO
    {

        public void inserir(Cliente cliente)
        {
            try
            {
                Banco.AbrirConexao();
                string comando = "insert into cliente (nome, cpf, rg, orgao, dataNasc, naturalidade, nacionalidade) values (@nome, @cpf, @rg, @orgao, @dataNasc, @naturalidade, @nacionalidade)";
                SqlCommand cmd = new SqlCommand(comando, Banco.Conexão);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@nome", cliente.Nome);

                cmd.Parameters.AddWithValue("@telefone", cliente.);

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("ERRO ao tentar inserir nova pessoa: " + e.Message);
            }
            finally
            {
                Banco.FecharConexao();
            }
        }

    }
}
