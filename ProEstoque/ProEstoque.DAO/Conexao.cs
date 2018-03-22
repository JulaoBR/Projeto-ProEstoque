using System.Data;
using MySql.Data.MySqlClient;

namespace ProEstoque.MODEL
{
    public class Conexao
    {
        //OBJETOS PARA CONECXAO
        private static MySqlConnection con = null;
        //==================================================

        //INFORMAÇÔES DO BANCO DE DADOS
        private static string servidorEndereco = "localhost";
        private static string servidorUsuario = "root";
        private static string servidorSenha = "";
        private static string servidorBD = "proestoque";
        //==================================================

       public Conexao()
       {

       }

        //METODO DE CONEXAO
        public static MySqlConnection conectar()

        {          
            try
            {
                if (con == null)
                {
                    con = new MySqlConnection();
                    con.ConnectionString = "server=" + servidorEndereco + ";user id=" + servidorUsuario + ";password=" + servidorSenha + "; database=" + servidorBD;
                    con.Open();
                }
                else
                {
                    con.Open();
                }                                  
            }
            catch
            {
                con = null;
            }

            return con;          
        }

        //METODO PARA FECHAR 
        public static void fechar()
        {
            if ((con.State == ConnectionState.Open) || (con.State == ConnectionState.Executing) || (con.State == ConnectionState.Fetching))
            {
                con.Close();
                con.Dispose();
            }
        }      
    }
}
    

