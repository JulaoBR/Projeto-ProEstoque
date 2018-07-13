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
    public class ProdutoDAO
    {
        private MySqlConnection con = null;

        ProdutoModel modelo = new ProdutoModel();
        private List<ClienteModel> listaFornecedor = new List<ClienteModel>();
        private string codProduto;
        private string descricao;
        private string tipoProduto;

        public ProdutoDAO()
        {

        }

        public ProdutoDAO(ProdutoModel modelo, List<ClienteModel> listaFornecedor)
        {
            this.modelo = modelo;
            this.listaFornecedor = listaFornecedor;
        }

        public ProdutoDAO(string codProduto, string descricao, string tipoProduto)
        {
            this.codProduto = codProduto;
            this.descricao = descricao;
            this.tipoProduto = tipoProduto;
        }

        public void Insert()
        {
            try
            {
                String sql = "INSERT INTO produto (pro_cod, tipo_cod, uni_cod, pro_descricao, pro_prazo_validade, pro_peso_liquido, pro_peso_bruto, pro_estoque_minimo, pro_estoque_maximo, pro_cod_barra) VALUES (@codOriginal, @tipoCod, @uniCod, @nomeProd, @prazoVal, @pesoLiq, @pesoBruto, @estMin, @estMax, @codBarra)";
                con = Conexao.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@codOriginal", modelo.pro_cod);
                cmd.Parameters.AddWithValue("@tipoCod", modelo.tipo_cod);
                cmd.Parameters.AddWithValue("@uniCod", modelo.uni_cod);
                cmd.Parameters.AddWithValue("@nomeProd", modelo.pro_descricao);
                cmd.Parameters.AddWithValue("@prazoVal", modelo.pro_prazo_validade);
                cmd.Parameters.AddWithValue("@pesoLiq", modelo.pro_peso_liquido);
                cmd.Parameters.AddWithValue("@pesoBruto", modelo.pro_peso_bruto);
                cmd.Parameters.AddWithValue("@estMin", modelo.pro_estoque_minimo);
                cmd.Parameters.AddWithValue("@estMax", modelo.pro_estoque_maximo);
                cmd.Parameters.AddWithValue("@codBarra", modelo.pro_cod_barra);

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

        public void InsertFornecedorProduto()
        {
            try
            {
                String sql = "INSERT INTO produto (pro_cod, tipo_cod, uni_cod, pro_descricao, pro_prazo_validade, pro_peso_liquido, pro_peso_bruto, pro_estoque_minimo, pro_estoque_maximo, pro_cod_barra) VALUES (@codOriginal, @tipoCod, @uniCod, @nomeProd, @prazoVal, @pesoLiq, @pesoBruto, @estMin, @estMax, @codBarra)";
                con = Conexao.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                //cmd.Parameters.AddWithValue("@codOriginal", modelo.pro_cod_original);

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
                String sql = "UPDATE produto SET pro_cod = @codOriginal, tipo_cod = @tipoCod, uni_cod = @uniCod, pro_descricao = @nomeProd, pro_prazo_validade = @prazoVal, pro_peso_liquido = @pesoLiq, pro_peso_bruto = @pesoBruto, pro_estoque_minimo = @estMin, pro_estoque_maximo = @proMax, pro_cod_barra = @codBarra WHERE pro_cod_original = @id ";
                con = Conexao.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", modelo.pro_cod);
                cmd.Parameters.AddWithValue("@codOriginal", modelo.pro_cod);
                cmd.Parameters.AddWithValue("@tipoCod", modelo.tipo_cod);
                cmd.Parameters.AddWithValue("@uniCod", modelo.uni_cod);
                cmd.Parameters.AddWithValue("@nomeProd", modelo.pro_descricao);
                cmd.Parameters.AddWithValue("@prazoVal", modelo.pro_prazo_validade);
                cmd.Parameters.AddWithValue("@pesoLiq", modelo.pro_peso_liquido);
                cmd.Parameters.AddWithValue("@pesoBruto", modelo.pro_peso_bruto);
                cmd.Parameters.AddWithValue("@estMin", modelo.pro_estoque_minimo);
                cmd.Parameters.AddWithValue("@estMax", modelo.pro_estoque_maximo);
                cmd.Parameters.AddWithValue("@codBarra", modelo.pro_cod_barra);

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
        public void Delete(int pro_cod)
        {
            try
            {
                String sql = "DELETE FROM produto WHERE pro_cod = @id ";
                con = Conexao.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", pro_cod);
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
        public ProdutoModel SelectByID(int id)
        {
            try
            {
                String sql = "SELECT pro_cod, tipo_cod, uni_cod, pro_descricao, pro_prazo_validade, pro_peso_liquido, pro_peso_bruto, pro_estoque_minimo, pro_estoque_maximo, pro_cod_barra FROM produto WHERE pro_cod_original = @id";
                con = Conexao.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader dr;

                ProdutoModel modelo = new ProdutoModel();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    modelo.pro_cod = Convert.ToInt32(dr["pro_cod"]);
                    modelo.tipo_cod = Convert.ToInt32(dr["tipo_cod"]);
                    modelo.uni_cod = Convert.ToInt32(dr["uni_cod"]);
                    modelo.pro_descricao = dr["pro_descricao"].ToString();
                    modelo.pro_prazo_validade = Convert.ToInt32(dr["pro_prazo_validade"].ToString());
                    modelo.pro_peso_liquido = Convert.ToDecimal(dr["pro_peso_liquido"].ToString());
                    modelo.pro_peso_bruto = Convert.ToDecimal(dr["pro_peso_bruto"]);
                    modelo.pro_estoque_minimo = Convert.ToDecimal(dr["pro_estoque_minimo"]);
                    modelo.pro_estoque_maximo = Convert.ToDecimal(dr["pro_estoque_maximo"]);
                    modelo.pro_cod_barra = dr["pro_cod_barra"].ToString();                   
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
                String sql = "SELECT A.pro_cod 'Codigo', A.pro_descricao 'Descricao', B.tipo_descricao 'Tipo Produto', C.uni_descricao 'Uni. Medida', A.pro_prazo_validade 'Prazo Val', A.pro_peso_liquido 'Peso Liq', A.pro_peso_bruto 'Peso Bruto', A.pro_estoque_minimo 'Est. Min', A.pro_estoque_maximo 'Est. Max', A.pro_cod_barra 'Codigo Barras'" +
                   "FROM produto AS A INNER JOIN tipo_produto AS B INNER JOIN unidade_medida AS C ON A.tipo_cod = B.tipo_cod AND A.uni_cod = C.uni_cod WHERE A.pro_descricao LIKE @descricao AND A.pro_cod LIKE @codProduto AND B.tipo_descricao LIKE @tipoProd";

                con = Conexao.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@codProduto", "%" + codProduto + "%");
                cmd.Parameters.AddWithValue("@descricao", "%" + descricao + "%");
                cmd.Parameters.AddWithValue("@tipoProd", "%" + tipoProduto + "%");
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
        public object ValidaProduto(int cli_cod_original)
        {
            try
            {
                MySqlConnection con = Conexao.conectar();
                String sql = "SELECT pro_cod FROM produto WHERE pro_cod = @codOriginal";
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
