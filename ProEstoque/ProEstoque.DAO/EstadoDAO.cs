using MySql.Data.MySqlClient;
using ProEstoque.MODEL;
using System;
using System.Data;

namespace ProEstoque.DAO
{
    public class EstadoDAO
    {
        private MySqlConnection con = null;

        public EstadoDAO()
        {

        }

        //METODO DE BUSCA POR ID
        public EstadoModel SelectByID(int id)
        {
            try
            {
                String sql = "SELECT est_cod, est_nome FROM estado WHERE est_cod = @id";
                con = Conexao.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader dr;

                EstadoModel estado = new EstadoModel();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    estado.est_cod = Convert.ToInt32(dr["est_cod"]);
                    estado.est_nome = dr["est_nome"].ToString();
                }
                return estado;
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
                String sql = "SELECT est_cod, est_nome FROM estado";
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
