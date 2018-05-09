using ProEstoque.DAO;
using ProEstoque.MODEL;
using System;
using System.Data;

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
                if (modelo.cli_cod_original == 0 || modelo.cli_nome_social == "" ||modelo.cli_nome_fantasia == "")
                    //RETORNO DE 1 OBJETO NAO COMPLETO
                    return 0;

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

        public int Update(ClienteModel modelo)
        {
            ClienteDAO dao = new ClienteDAO();

            return 0;
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

        public bool ValidarUsuario(int codigo)
        {
            ClienteDAO dao = new ClienteDAO();
            if (dao.ValidaUsuario(codigo) != null)
                //RETORNO DE 0 OBJETO JA EXISTE
                return true;

            return false;
        }
    }
}
