using MySql.Data.MySqlClient;
using ProEstoque.MODEL;
using System;
using System.Data;

namespace ProEstoque.DAO
{
    public class UnidadeMedidaDAO
    {
        private MySqlConnection con = null;

        public UnidadeMedidaDAO()
        {

        }

        //METODO DE INSERT
        public void Insert(UnidadeMedidaModel unidade)
        {
            try
            {
                String sql = "INSERT INTO unidade_medida (uni_descricao) VALUES (@descricao)";
                con = Conexao.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@descricao", unidade.uni_descricao);
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
        public void Update(UnidadeMedidaModel unidade)
        {
            try
            {
                String sql = "UPDATE unidade_medida SET uni_descricao = @descricao WHERE uni_cod = @id ";
                con = Conexao.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", unidade.uni_cod);
                cmd.Parameters.AddWithValue("@descricao", unidade.uni_descricao);
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
        public void Delete(int unidade)
        {
            try
            {
                String sql = "DELETE FROM unidade_medida WHERE uni_cod = @id ";
                con = Conexao.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", unidade);
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
        public UnidadeMedidaModel SelectByID(int id)
        {
            try
            {
                String sql = "SELECT * FROM unidade_medida WHERE uni_cod = @id";
                con = Conexao.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader dr;

                UnidadeMedidaModel unidade = new UnidadeMedidaModel();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    unidade.uni_cod = Convert.ToInt32(dr["uni_cod"]);
                    unidade.uni_descricao = dr["uni_descricao"].ToString();
                }
                return unidade;
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
                String sql = "SELECT uni_cod, uni_descricao FROM unidade_medida";
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
    }
}
