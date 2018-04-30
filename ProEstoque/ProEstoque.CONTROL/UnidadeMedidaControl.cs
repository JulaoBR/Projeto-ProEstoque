using ProEstoque.DAO;
using ProEstoque.MODEL;
using System;
using System.Data;

namespace ProEstoque.CONTROL
{
    public class UnidadeMedidaControl
    {
        public UnidadeMedidaControl()
        {

        }

        //METODDO DE INSERIR
        public bool Inserir(UnidadeMedidaModel unidade)
        {
            UnidadeMedidaDAO dao = new UnidadeMedidaDAO();

            //VERIFICA SE TEM DADOS DENTRO DO OBJETO
            if (unidade.uni_descricao != string.Empty)
            {
                dao.Insert(unidade);
                //SE DER TUDO CERTO RETORNA TRUE
                return true;
            }
            else
            {
                //SE NAO RETORNA FALSE
                return false;
            }
        }

        public bool Update(UnidadeMedidaModel unidade)
        {
            UnidadeMedidaDAO dao = new UnidadeMedidaDAO();

            if (unidade.uni_cod != 0 || unidade.uni_descricao != string.Empty)
            {
                dao.Update(unidade);
                return true;
            }
            else
            {
                return false;
            }
        }

        //METODO DE BUSCA TOTAL, TODOS OS DADOS DA TABELA
        public DataTable Select()
        {
            UnidadeMedidaDAO dao = new UnidadeMedidaDAO();
            return dao.Select();
        }

        //RETORNA UM OBJETO DO TIPO UNIDADE DE MEDIDA
        public UnidadeMedidaModel SelectByID(int id)
        {
            UnidadeMedidaDAO dao = new UnidadeMedidaDAO();
            return dao.SelectByID(id);
        }

        public bool Excluir(string codigo)
        {
            UnidadeMedidaDAO dao = new UnidadeMedidaDAO();

            if (codigo != string.Empty )
            {
                dao.Delete(Convert.ToInt32(codigo));
                return true;
            }
            else
            {
                return false;
            }            
        }
    }
}
