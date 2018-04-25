using ProEstoque.DAO;
using ProEstoque.MODEL;

namespace ProEstoque.CONTROL
{
    public class UnidadeMedidaControl
    {
        public UnidadeMedidaControl()
        {

        }

        public bool Inserir(UnidadeMedidaModel unidade)
        {
            UnidadeMedidaDAO dao = new UnidadeMedidaDAO();

            if (unidade.uni_descricao != string.Empty)
            {
                dao.Insert(unidade);
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
