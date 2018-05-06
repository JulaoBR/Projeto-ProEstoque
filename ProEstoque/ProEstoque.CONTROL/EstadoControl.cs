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
    public class EstadoControl
    {
        public EstadoControl()
        {

        }

        //METODO DE BUSCA TOTAL, TODOS OS DADOS DA TABELA
        public DataTable Select()
        {
            EstadoDAO dao = new EstadoDAO();
            return dao.Select();
        }

        //RETORNA UM OBJETO DO TIPO UNIDADE DE MEDIDA
        public EstadoModel SelectByID(int id)
        {
            EstadoDAO dao = new EstadoDAO();
            return dao.SelectByID(id);
        }

    }
}
