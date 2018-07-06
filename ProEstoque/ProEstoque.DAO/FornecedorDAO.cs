using MySql.Data.MySqlClient;
using ProEstoque.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEstoque.DAO
{
    public class FornecedorDAO
    {
        private MySqlConnection con = null;
        private FornecedorModel modelo;
        private string codFornecedor;
        private string razaoSocial;
        private string apelido;

        public FornecedorDAO()
        {

        }

        public FornecedorDAO(FornecedorModel model)
        {
            this.modelo = model;
        }

        public FornecedorDAO(string codFornecedor, string razaoSocial, string apelido)
        {
            this.codFornecedor = codFornecedor;
            this.razaoSocial = razaoSocial;
            this.apelido = apelido;
        }

        //METODO DE INSERT
        public void Insert()
        {
            try
            {
                String sql = "INSERT INTO fornecedor (for_razao_social, for_apelido, for_cnpj, for_data_cadastro) VALUES (@cod, @razaoSocial, @apelido, @cnpj, @dataCad )";
                con = Conexao.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@razaoSocial", modelo.for_razao_social);
                cmd.Parameters.AddWithValue("@apelido", modelo.for_apelido);
                cmd.Parameters.AddWithValue("@cnpj", modelo.for_cnpj);
                cmd.Parameters.AddWithValue("@dataCad", modelo.for_data_cadastro);

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
                String sql = "UPDATE fornecedor SET for_cod = @cod, for_razao_social = @razaoSocial, for_apelido = @apelido, for_cnpj = @cnpj, for_data_cadastro = @dataCad WHERE for_cod = @cod ";
                con = Conexao.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@cod", modelo.for_cod);
                cmd.Parameters.AddWithValue("@razaoSocial", modelo.for_razao_social);
                cmd.Parameters.AddWithValue("@apelido", modelo.for_apelido);
                cmd.Parameters.AddWithValue("@cnpj", modelo.for_cnpj);
                cmd.Parameters.AddWithValue("@dataCad", modelo.for_data_cadastro);

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
                String sql = "DELETE FROM fornecedor WHERE for_cod = @id ";
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
        public FornecedorModel SelectByID(int id)
        {
            try
            {
                String sql = "SELECT for_cod, for_razao_social, for_apelido, for_cnpj, for_data_cadastro FROM fornecedor WHERE for_cod = @id";
                con = Conexao.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader dr;

                FornecedorModel modelo = new FornecedorModel();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    modelo.for_cod = Convert.ToInt32(dr["for_cod"]);
                    modelo.for_razao_social = dr["for_razao_social"].ToString();
                    modelo.for_apelido = dr["for_apelido"].ToString();
                    modelo.for_cnpj = dr["for_cnpj"].ToString();
                    modelo.for_data_cadastro = Convert.ToDateTime(dr["for_data_Cadastro"].ToString()); 
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
                String sql = "SELECT for_cod 'Codigo', for_razao_social 'Razao Social', for_apelido 'Nome Fantasia', for_cnpj 'CNPJ', for_data_cadastro 'Data Cadastro' " +
                   "FROM fornecedor WHERE for_cod LIKE @cod AND for_razao_social LIKE @social AND for_apelido LIKE @apelido";

                con = Conexao.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@cod", "%" + codFornecedor + "%");
                cmd.Parameters.AddWithValue("@social", "%" + razaoSocial + "%");
                cmd.Parameters.AddWithValue("@apelido", "%" + apelido + "%");
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
        public object ValidaFornecdor(int for_cod)
        {
            try
            {
                MySqlConnection con = Conexao.conectar();
                String sql = "SELECT for_cod FROM fornecedor WHERE for_cod=@codOriginal";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@codOriginal", for_cod);

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
