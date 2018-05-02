using MySql.Data.MySqlClient;
using ProEstoque.MODEL;
using System;
using System.Data;

namespace ProEstoque.DAO
{
    public class MotivoDAO
    {
        private MySqlConnection con = null;

        public MotivoDAO()
        {

        }

        //METODO DE INSERT
        public void Insert(MotivoModel motivo)
        {
            try
            {
                String sql = "INSERT INTO motivo (mot_descricao) VALUES (@descricao)";
                con = Conexao.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@descricao", motivo.mot_descricao);
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
        public void Update(MotivoModel motivo)
        {
            try
            {
                String sql = "UPDATE motivo SET mot_descricao = @descricao WHERE mot_cod = @id ";
                con = Conexao.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", motivo.mot_cod);
                cmd.Parameters.AddWithValue("@descricao", motivo.mot_descricao);
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
                String sql = "DELETE FROM motivo WHERE mot_cod = @id ";
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
        public MotivoModel SelectByID(int id)
        {
            try
            {
                String sql = "SELECT mot_cod, mot_descricao FROM motivo WHERE mot_cod = @id";
                con = Conexao.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader dr;

                MotivoModel motivo = new MotivoModel();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    motivo.mot_cod = Convert.ToInt32(dr["mot_cod"]);
                    motivo.mot_descricao = dr["mot_descricao"].ToString();
                }
                return motivo;
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
                String sql = "SELECT mot_cod, mot_descricao FROM motivo";
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
