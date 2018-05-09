using MySql.Data.MySqlClient;
using ProEstoque.MODEL;
using System;
using System.Data;

namespace ProEstoque.DAO
{
    public class ClienteDAO
    {
        private MySqlConnection con = null;

        public ClienteDAO()
        {

        }

        //METODO DE INSERT
        public void Insert(ClienteModel modelo)
        {
            try
            {
                String sql = "INSERT INTO cliente (cli_cod_original, est_cod, cid_cod, cli_nome_social, cli_nome_fantasia, cli_endereco, cli_bairro, cli_numero, cli_cep, cli_tipo_pessoa, cli_data_cadastro) VALUES (@codOriginal, @estCod, @cidCod, @nomeSocial, @nomeFantasia, @endereco, @bairro, @numero, @cep, @tipoPessoa, @dtCadastro)";
                con = Conexao.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@codOriginal", modelo.cli_cod_original);
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
        public void Update(ClienteModel modelo)
        {
            try
            {
                String sql = "UPDATE usuario SET cli_cod_original = @codOriginal, est_cod = @estCod, cid_cod = @cidCod, cli_nome_social = @nomeSocial, cli_nome_fantasia = @nomeFantasia, cli_endereco = @endereco, cli_bairro = @bairro, cli_numero = @numero, cli_cep = @cep, cli_tipo_pessoa = @tipoPessoa WHERE cli_cod = @id ";
                con = Conexao.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", modelo.cli_cod);
                cmd.Parameters.AddWithValue("@codOriginal", modelo.cli_cod_original);
                cmd.Parameters.AddWithValue("@estCod", modelo.est_cod);
                cmd.Parameters.AddWithValue("@cidCod", modelo.cid_cod);
                cmd.Parameters.AddWithValue("@nomeSocial", modelo.cli_nome_social);
                cmd.Parameters.AddWithValue("@nomeFantasia", modelo.cli_nome_fantasia);
                cmd.Parameters.AddWithValue("@endereco", modelo.cli_endereco);
                cmd.Parameters.AddWithValue("@bairro", modelo.cli_bairro);
                cmd.Parameters.AddWithValue("@numero", modelo.cli_numero);
                cmd.Parameters.AddWithValue("@cep", modelo.cli_cep);
                cmd.Parameters.AddWithValue("@tipoPessia", modelo.cli_tipo_pessoa);

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
                String sql = "SELECT cli_cod ,cli_cod_original, est_cod, cid_cod, cli_nome_social, cli_nome_fantasia, cli_endereco, cli_bairro, cli_numero, cli_cep, cli_tipo_pessoa FROM cliente WHERE cli_cod = @id";
                con = Conexao.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader dr;

                ClienteModel modelo = new ClienteModel();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    modelo.cli_cod = Convert.ToInt32(dr["cli_cod"]);
                    modelo.cli_cod_original = Convert.ToInt32(dr["cli_cod_original"]);
                    modelo.est_nome = dr["est_nome"].ToString();
                    modelo.cid_nome = dr["cid_nome"].ToString();
                    modelo.cli_nome_social = dr["cli_nome_social"].ToString();
                    modelo.cli_nome_fantasia = dr["cli_nome_fantasia"].ToString();
                    modelo.cli_endereco = dr["cli_endereco"].ToString();
                    modelo.cli_bairro = dr["cli_bairro"].ToString();
                    modelo.cli_numero = Convert.ToInt32(dr["cli_numero"]);
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
                String sql = "SELECT cli_cod ,cli_cod_original, est_cod, cid_cod, cli_nome_social, cli_nome_fantasia, cli_endereco, cli_bairro, cli_numero, cli_cep, cli_tipo_pessoa FROM cliente";
                con = Conexao.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con);
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
        public object ValidaUsuario(int cli_cod_original)
        {
            try
            {
                MySqlConnection con = Conexao.conectar();
                String sql = "SELECT cli_cod_original FROM cliente WHERE cli_cod_original=@codOriginal";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@codOriginal", cli_cod_original);

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
