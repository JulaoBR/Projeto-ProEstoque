using ProEstoque.DAO;
using ProEstoque.MODEL;
using System;
using System.Collections.Generic;
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
    }
}
