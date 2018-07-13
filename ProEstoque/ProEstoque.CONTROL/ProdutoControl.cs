using ProEstoque.DAO;
using ProEstoque.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEstoque.CONTROL
{
    public class ProdutoControl
    {
        ProdutoModel modelo = new ProdutoModel();
        private List<ClienteModel> listaFornecedor = new List<ClienteModel>();
        private string codProduto;
        private string descricao;
        private string tipoProduto;

        public ProdutoControl()
        {

        }

        public ProdutoControl(ProdutoModel modelo, List<ClienteModel> listaFornecedor)
        {
            this.modelo = modelo;
            this.listaFornecedor = listaFornecedor;
        }

        public ProdutoControl(string codProduto, string descricao, string tipoProduto)
        {
            this.codProduto = codProduto;
            this.descricao = descricao;
            this.tipoProduto = tipoProduto;
        }


        //METODDO DE INSERIR
        public int Inserir()
        {
            ProdutoDAO dao = new ProdutoDAO(modelo, listaFornecedor);
            try
            {
                if (modelo.pro_cod == 0 || modelo.pro_descricao == string.Empty)
                    //RETORNO DE 1 OBJETO NAO COMPLETO
                    return 0;

                dao.Insert();
                //RETORNO DE 2 OK
                return 2;
            }
            catch
            {
                //RETORNO DE 3 ERRO NA OPERAÇÃO
                return 3;
            }
        }

        public int Update()
        {
            ProdutoDAO dao = new ProdutoDAO();

            return 0;
        }

        //METODO DE BUSCA TOTAL, TODOS OS DADOS DA TABELA
        public DataTable Select()
        {
            ProdutoDAO dao = new ProdutoDAO(codProduto, descricao, tipoProduto);
            return dao.Select();
        }

        //RETORNA UM OBJETO DO TIPO UNIDADE DE MEDIDA
        public ProdutoModel SelectByID(int id)
        {
            ProdutoDAO dao = new ProdutoDAO();
            return dao.SelectByID(id);
        }

        public bool Excluir(string codigo)
        {
            ProdutoDAO dao = new ProdutoDAO();

            if (codigo != string.Empty)
            {
                dao.Delete(Convert.ToInt32(codigo));
                return true;
            }
            else
            {
                return false;
            }
        }

        //verifica se o fornecedor da tela de cadastro de produto ja foi selecionado
        public bool VarificaCliente(List<ClienteModel> listaCliente, int codigo)
        {
            foreach (var item in listaCliente)
            {
                if (codigo != item.cli_cod)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        public bool ValidarProduto(int codigo)
        {
            ProdutoDAO dao = new ProdutoDAO();
            if (dao.ValidaProduto(codigo) != null)
                //RETORNO DE 0 OBJETO JA EXISTE
                return true;

            return false;
        }
    }
}
