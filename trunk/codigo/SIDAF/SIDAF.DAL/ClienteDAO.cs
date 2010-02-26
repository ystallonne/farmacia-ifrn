﻿using System;
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

                cmd.Parameters.AddWithValue("@cpf", cliente.Cpf);

                cmd.Parameters.AddWithValue("@rg", cliente.Rg);

                cmd.Parameters.AddWithValue("@orgao", cliente.OrgaoEmissor);

                cmd.Parameters.AddWithValue("@dataNasc", cliente.DataNasc);

                cmd.Parameters.AddWithValue("@naturalidade", cliente.Naturalidade);

                cmd.Parameters.AddWithValue("@nacionalidade", cliente.Nacionalidade);

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("ERRO ao tentar inserir novo Cliente: " + e.Message);
            }
            finally
            {
                Banco.FecharConexao();
            }
        }

        public void atualizar(Cliente cliente)
        {
            try
            {
                Banco.AbrirConexao();
                string comando = @"update cliente set nome = @nome, cpf = @cpf, rg = @rg, orgao = @orgao, dataNasc = @dataNasc, naturalidade = @naturalidade, nacionalidade = @nacionalidade where id = @id";
                SqlCommand cmd = new SqlCommand(comando, Banco.Conexão);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@id", cliente.Oid.Value);
                cmd.Parameters.AddWithValue("@nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@cpf", cliente.Cpf);
                cmd.Parameters.AddWithValue("@rg", cliente.Rg);
                cmd.Parameters.AddWithValue("@orgao", cliente.OrgaoEmissor);
                cmd.Parameters.AddWithValue("@dataNasc", cliente.DataNasc);
                cmd.Parameters.AddWithValue("@naturalidade", cliente.Naturalidade);
                cmd.Parameters.AddWithValue("@nacionalidade", cliente.Nacionalidade);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("ERRO ao tentar atualizar informações do cliente: " + e.Message);
            }
            finally
            {
                Banco.FecharConexao();
            }
        }

        public void excluir(Cliente cliente)
        {
            try
            {
                Banco.AbrirConexao();
                string comando = @"delete from cliente where id = @id";
                SqlCommand cmd = new SqlCommand(comando, Banco.Conexão);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", cliente.Oid.Value);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("ERRO ao tentar excluir um cliente: " + e.Message);
            }
            finally
            {
                Banco.FecharConexao();
            }
        }

        public Clientes selecionar()
        {
            Clientes clientes = new Clientes();
            try
            {
                Banco.AbrirConexao();
                string comando = @"select * from cliente";
                SqlCommand cmd = new SqlCommand(comando, Banco.Conexão);
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                Pessoa pessoa = null;
                while (dr.Read())
                {
                    pessoa = new Pessoa();
                    pessoa.Oid = int.Parse(dr["id"].ToString());
                    pessoa.Nome = dr["nome"].ToString();
                    pessoa.Telefone = dr["telefone"].ToString();
                    pessoas.Add(pessoa);
                }
            }
            catch (Exception e)
            {
                throw new Exception("ERRO ao tentar selecionar pessoas: " + e.Message);
            }
            finally
            {
                Banco.FecharConexao();
            }
            return pessoas;
        }

    }
}
