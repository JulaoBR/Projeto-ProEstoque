﻿using MySql.Data.MySqlClient;
using ProEstoque.MODEL;
using System;
using System.Data;

namespace ProEstoque.DAO
{
    public class ClienteDAO
    {
        private MySqlConnection con = null;
        private ClienteModel modelo = new ClienteModel();
        private string codCliente;
        private string razaoSocial;
        private string apelido;

        public ClienteDAO()
        {

        }

        public ClienteDAO(ClienteModel model)
        {
            this.modelo = model;
        }

        public ClienteDAO(string codCliente, string razaoSocial, string apelido)
        {
            this.codCliente = codCliente;
            this.razaoSocial = razaoSocial;
            this.apelido = apelido;
        }

        //METODO DE INSERT
        public void Insert()
        {
            try
            {
                String sql = "INSERT INTO cliente (cli_cod, est_cod, cid_cod, cli_nome_social, cli_nome_fantasia, cli_endereco, cli_bairro, cli_numero, cli_cep, cli_tipo_pessoa, cli_data_cadastro) VALUES (@codOriginal, @estCod, @cidCod, @nomeSocial, @nomeFantasia, @endereco, @bairro, @numero, @cep, @tipoPessoa, @dtCadastro)";
                con = Conexao.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@codOriginal", modelo.cli_cod);
                cmd.Parameters.AddWithValue("@estCod", modelo.est_cod);
                cmd.Parameters.AddWithValue("@cidCod", modelo.cid_cod);
                cmd.Parameters.AddWithValue("@nomeSocial", modelo.cli_nome_social);
                cmd.Parameters.AddWithValue("@nomeFantasia", modelo.cli_nome_fantasia);
                cmd.Parameters.AddWithValue("@endereco", modelo.cli_endereco);
                cmd.Parameters.AddWithValue("@bairro", modelo.cli_bairro);
                cmd.Parameters.AddWithValue("@numero", modelo.cli_numero);
                cmd.Parameters.AddWithValue("@cep", modelo.cli_cep);
                cmd.Parameters.AddWithValue("@tipoPessoa", modelo.cli_tipo_pessoa);
                cmd.Parameters.AddWithValue("@dtCadastro", modelo.cli_data_cadastro);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conexao.fechar();
            }
        }

        //METODO DE UPDATE 
        public void Update()
        {
            try
            {
                String sql = "UPDATE cliente SET cli_cod = @codOriginal, est_cod = @estCod, cid_cod = @cidCod, cli_nome_social = @nomeSocial, cli_nome_fantasia = @nomeFantasia, cli_endereco = @endereco, cli_bairro = @bairro, cli_numero = @numero, cli_cep = @cep, cli_tipo_pessoa = @tipoPessoa WHERE cli_cod = @codOriginal ";
                con = Conexao.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@codOriginal", modelo.cli_cod);
                cmd.Parameters.AddWithValue("@estCod", modelo.est_cod);
                cmd.Parameters.AddWithValue("@cidCod", modelo.cid_cod);
                cmd.Parameters.AddWithValue("@nomeSocial", modelo.cli_nome_social);
                cmd.Parameters.AddWithValue("@nomeFantasia", modelo.cli_nome_fantasia);
                cmd.Parameters.AddWithValue("@endereco", modelo.cli_endereco);
                cmd.Parameters.AddWithValue("@bairro", modelo.cli_bairro);
                cmd.Parameters.AddWithValue("@numero", modelo.cli_numero);
                cmd.Parameters.AddWithValue("@cep", modelo.cli_cep);
                cmd.Parameters.AddWithValue("@tipoPessoa", modelo.cli_tipo_pessoa);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conexao.fechar();
            }
        }

        //METODO DE DELETE
        public void Delete(int cli_cod)
        {
            try
            {
                String sql = "DELETE FROM cliente WHERE cli_cod = @id ";
                con = Conexao.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", cli_cod);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conexao.fechar();
            }
        }

        //METODO DE BUSCA POR ID
        public ClienteModel SelectByID(int id)
        {
            try
            {
                String sql = "SELECT cli_cod , est_cod, cid_cod, cli_nome_social, cli_nome_fantasia, cli_endereco, cli_bairro, cli_numero, cli_cep, cli_tipo_pessoa FROM cliente WHERE cli_cod = @id";
                con = Conexao.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader dr;

                ClienteModel modelo = new ClienteModel();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    modelo.cli_cod = Convert.ToInt32(dr["cli_cod"]);
                    modelo.est_cod = Convert.ToInt32(dr["est_cod"].ToString());
                    modelo.cid_cod = Convert.ToInt32(dr["cid_cod"].ToString());
                    modelo.cli_nome_social = dr["cli_nome_social"].ToString();
                    modelo.cli_nome_fantasia = dr["cli_nome_fantasia"].ToString();
                    modelo.cli_endereco = dr["cli_endereco"].ToString();
                    modelo.cli_bairro = dr["cli_bairro"].ToString();
                    modelo.cli_numero = dr["cli_numero"].ToString();
                    modelo.cli_cep = dr["cli_cep"].ToString();
                    modelo.cli_tipo_pessoa = dr["cli_tipo_pessoa"].ToString();
                }
                return modelo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conexao.fechar();
            }
        }

        //METODO DE BUSCA GERAL
        public DataTable Select()
        {
            try
            {
                String sql = "SELECT A.cli_cod 'Codigo', A.cli_nome_social 'Razao Social', A.cli_nome_fantasia 'Nome Fantasia', A.cli_endereco 'Endereco', A.cli_bairro 'Bairro', A.cli_numero 'Numero', A.cli_cep 'Cep', B.est_nome 'Estado', C.cid_nome 'Cidade',A.cli_tipo_pessoa 'Tipo Pessoa' " + 
                   "FROM cliente AS A INNER JOIN estado AS B INNER JOIN cidade AS C ON A.est_cod = B.est_cod AND A.cid_cod = C.cid_cod WHERE A.cli_nome_social LIKE @social AND A.cli_nome_fantasia LIKE @fantasia AND A.cli_cod LIKE @codCliente" ;

                con = Conexao.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@codCliente", "%" + codCliente + "%");
                cmd.Parameters.AddWithValue("@social", "%" + razaoSocial + "%");
                cmd.Parameters.AddWithValue("@fantasia", "%" + apelido + "%");
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conexao.fechar();
            }
        }

        //METODO PARA VALIDAR 
        public object ValidaUsuario(int cli_cod)
        {
            try
            {
                MySqlConnection con = Conexao.conectar();
                String sql = "SELECT cli_cod FROM cliente WHERE cli_cod=@codOriginal";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@codOriginal", cli_cod);

                return cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {
                Conexao.fechar();
            }
        }
    }
}
