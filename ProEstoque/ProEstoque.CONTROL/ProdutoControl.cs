using ProEstoque.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEstoque.CONTROL
{
    public class ProdutoControl
    {
        public ProdutoControl()
        {

        }


        public bool VarificaCliente(List<ClienteModel> listaCliente, int codigo)
        {
            foreach (var item in listaCliente)
            {
                if (codigo != item.cli_cod_original)
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
    }
}
