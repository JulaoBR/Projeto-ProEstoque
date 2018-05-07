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
    public class ClienteControl
    {

        public ClienteControl()
        {

        }

        //METODDO DE INSERIR
        public int Inserir(ClienteModel modelo)
        {
            ClienteDAO dao = new ClienteDAO();
            try
            {
                if (dao.ValidaUsuario(modelo.cli_cod_original, modelo.cli_nome_fantasia))
                    //RETORNO DE 0 OBJETO JA EXISTE
                    return 0;

                if (modelo != null)
                    //RETORNO DE 1 OBJETO NAO COMPLETO
                    return 1;

                dao.Insert(modelo);
                //RETORNO DE 2 OK
                return 2;
            }
            catch
            {
                //RETORNO DE 3 ERRO NA OPERAÇÃO
                return 3;
            }                                  
        }

        public bool Update(ClienteModel modelo)
        {
            ClienteDAO dao = new ClienteDAO();

            return false;
        }

        //METODO DE BUSCA TOTAL, TODOS OS DADOS DA TABELA
        public DataTable Select()
        {
            ClienteDAO dao = new ClienteDAO();
            return dao.Select();
        }

        //RETORNA UM OBJETO DO TIPO UNIDADE DE MEDIDA
        public ClienteModel SelectByID(int id)
        {
            ClienteDAO dao = new ClienteDAO();
            return dao.SelectByID(id);
        }

        public bool Excluir(string codigo)
        {
            ClienteDAO dao = new ClienteDAO();

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
    }
}
