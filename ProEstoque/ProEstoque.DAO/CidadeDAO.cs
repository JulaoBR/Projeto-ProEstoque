using MySql.Data.MySqlClient;
using ProEstoque.MODEL;
using System;
using System.Data;

namespace ProEstoque.DAO
{
    public class CidadeDAO
    {
        private MySqlConnection con = null;

        public CidadeDAO()
        {

        }

        //METODO DE BUSCA POR ID
        public CidadeModel SelectByID(int id)
        {
            try
            {
                String sql = "SELECT cid_cod, cid_nome FROM cidade WHERE cid_cod = @id";
                con = Conexao.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader dr;

                CidadeModel cidade = new CidadeModel();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    cidade.cid_cod = Convert.ToInt32(dr["cid_cod"]);
                    cidade.cid_nome = dr["cid_nome"].ToString();
                }
                return cidade;
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
        public DataTable Select(int est_cod)
        {
            try
            {
                String sql = "SELECT cid_cod, cid_nome FROM cidade WHERE cid_uf = @id";
                con = Conexao.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", est_cod);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
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
