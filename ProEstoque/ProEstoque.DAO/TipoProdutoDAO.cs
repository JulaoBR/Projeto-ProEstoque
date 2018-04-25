using MySql.Data.MySqlClient;
using ProEstoque.MODEL;
using System;
using System.Data;


namespace ProEstoque.DAO
{
    public class TipoProdutoDAO
    {
        private MySqlConnection con = null;

        public TipoProdutoDAO()
        {

        }

        //METODO DE INSERT
        public void Insert(TipoProdutoModel tipo)
        {
            try
            {
                String sql = "INSERT INTO tipo_produto (tipo_descricao) VALUES (@descricao)";
                con = Conexao.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@descricao", tipo.tipo_descricao);
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
        public void Update(TipoProdutoModel tipo)
        {
            try
            {
                String sql = "UPDATE tipo_produto SET tipo_descricao = @descricao WHERE tipo_cod = @id ";
                con = Conexao.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", tipo.tipo_cod);
                cmd.Parameters.AddWithValue("@descricao", tipo.tipo_descricao);
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
        public void Delete(TipoProdutoModel tipo)
        {
            try
            {
                String sql = "DELETE FROM tipo_produto WHERE tipo_cod = @id ";
                con = Conexao.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", tipo.tipo_cod);
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
        public TipoProdutoModel SelectByID(int id)
        {
            try
            {
                String sql = "SELECT * FROM tipo_produto WHERE tipo_cod = @id";
                con = Conexao.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader dr;

                TipoProdutoModel tipo = new TipoProdutoModel();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    tipo.tipo_cod = Convert.ToInt32(dr["tipo_cod"]);
                    tipo.tipo_descricao = dr["tipo_descricao"].ToString();
                }
                return tipo;
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
                String sql = "SELECT tipo_cod, tipo_descricao FROM tipo_produto";
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

