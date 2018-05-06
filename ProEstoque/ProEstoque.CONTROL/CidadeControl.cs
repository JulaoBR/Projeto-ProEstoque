using ProEstoque.DAO;
using ProEstoque.MODEL;
using System.Data;

namespace ProEstoque.CONTROL
{
    public class CidadeControl
    {
        public CidadeControl()
        {

        }

        //METODO DE BUSCA TOTAL, TODOS OS DADOS DA TABELA
        public DataTable Select(int est_cod)
        {
            CidadeDAO dao = new CidadeDAO();
            return dao.Select(est_cod);
        }

        //RETORNA UM OBJETO DO TIPO UNIDADE DE MEDIDA
        public CidadeModel SelectByID(int id)
        {
            CidadeDAO dao = new CidadeDAO();
            return dao.SelectByID(id);
        }
    }
}
