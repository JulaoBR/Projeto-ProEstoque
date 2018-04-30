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
    public class TipoProdutoControl
    {

        public TipoProdutoControl()
        {

        }

        public bool Inserir(TipoProdutoModel tipo)
        {
            TipoProdutoDAO dao = new TipoProdutoDAO();

            if (tipo.tipo_descricao != string.Empty)
            {
                dao.Insert(tipo);
                return true;
            }
            else
            {
                return false;
            }           
        }

        public bool Update(TipoProdutoModel tipo)
        {
            TipoProdutoDAO dao = new TipoProdutoDAO();

            if (tipo.tipo_cod != 0 || tipo.tipo_descricao != string.Empty)
            {
                dao.Update(tipo);
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable Select()
        {
            TipoProdutoDAO dao = new TipoProdutoDAO();
            return dao.Select();
        }

        //RETORNA UM OBJETO DO TIPO UNIDADE DE MEDIDA
        public TipoProdutoModel SelectByID(int id)
        {
            TipoProdutoDAO dao = new TipoProdutoDAO();
            return dao.SelectByID(id);
        }
    }
}
