using MySql.Data.MySqlClient;
using ProEstoque.MODEL;
using System;
using System.Data;

namespace ProEstoque.DAO
{
    public class UsuarioDAO 
    {
        private MySqlConnection con = null;

        public UsuarioDAO()
        {

        }

        //METODO DE INSERT
        public void Insert(UsuarioModel usuario)
        {
            try
            {
                String sql = "INSERT INTO usuario (usu_nome, usu_telefone, usu_login, usu_senha) VALUES (@nome, @telefone, @login, @senha)";
                con = Conexao.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", usuario.usu_nome);
                cmd.Parameters.AddWithValue("@telefone", usuario.usu_telefone);
                cmd.Parameters.AddWithValue("@login", usuario.usu_login);
                cmd.Parameters.AddWithValue("@senha", usuario.usu_senha);
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
        public void Update(UsuarioModel usuario)
        {
            try
            {
                String sql = "UPDATE usuario SET usu_nome= @nome ,usu_telefone=@telefone, usu_login= @login, usu_senha = @senha WHERE usu_cod = @id ";
                con = Conexao.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", usuario.usu_cod);
                cmd.Parameters.AddWithValue("@nome", usuario.usu_nome);
                cmd.Parameters.AddWithValue("@telefone", usuario.usu_telefone);
                cmd.Parameters.AddWithValue("@login", usuario.usu_login);
                cmd.Parameters.AddWithValue("@senha", usuario.usu_senha);
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
        public void Delete(UsuarioModel usuario)
        {
            try
            {
                String sql = "DELETE FROM usuario WHERE usu_cod = @id ";
                con = Conexao.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", usuario.usu_cod);
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
        public UsuarioModel SelectByID(int id)
        {
            try
            {
                String sql = "SELECT * FROM usuario WHERE usu_cod = @id";
                con = Conexao.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader dr;

                UsuarioModel usuario = new UsuarioModel();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    usuario.usu_cod = Convert.ToInt32(dr["id"]);
                    usuario.usu_nome = dr["usu_nome"].ToString();
                    usuario.usu_telefone = dr["usu_telefone"].ToString();
                    usuario.usu_login = dr["usu_login"].ToString();
                    usuario.usu_senha = dr["usu_senha"].ToString();
                }
                return usuario;
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
                String sql = "SELECT * FROM usuario";
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

        //METODO PARA VALIDAR O USUARIO NA HORA DO LOGIN
        public bool ValidaUsuario(string usuario, string senha)
        {
            try
            {
                int retorno = -1;
                MySqlConnection con = Conexao.conectar();
                String sql = "SELECT COUNT(*) FROM usuario WHERE usu_login=@Login AND usu_senha=@Senha";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Login", usuario);
                cmd.Parameters.AddWithValue("@Senha", senha);

                retorno = Convert.ToInt32(cmd.ExecuteScalar());

                return retorno > 0;
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
