using ProEstoque.DAO;
using ProEstoque.MODEL;
using System;
using System.Data;

namespace ProEstoque.CONTROL
{
    public class ClienteControl
    {
        private ClienteModel modelo = new ClienteModel();
        private string codCliente;
        private string razaoSocial;
        private string apelido;

        public ClienteControl()
        {

        }

        public ClienteControl(ClienteModel model)
        {
            this.modelo = model;
        }

        public ClienteControl(string codCliente, string razaoSocial, string apelido)
        {
            this.codCliente = codCliente;
            this.razaoSocial = razaoSocial;
            this.apelido = apelido;
        }

        //METODDO DE INSERIR
        public int Inserir()
        {      
            try
            {
                ClienteDAO dao = new ClienteDAO(modelo);
                if (modelo.cli_cod == 0 || modelo.cli_nome_social == "" ||modelo.cli_nome_fantasia == "" || modelo.cid_cod == 0  || modelo.est_cod == 0)
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
            try
            {
                ClienteDAO dao = new ClienteDAO(modelo);

                if (modelo.cli_cod == 0 || modelo.cli_nome_social == "" || modelo.cli_nome_fantasia == "" || modelo.cid_cod == 0 || modelo.est_cod == 0)
                    //RETORNO DE 1 OBJETO NAO COMPLETO
                    return 0;

                dao.Update();
                //RETORNO DE 2 OK
                return 2;

            }
            catch
            {
                return 3;
            }
            
        }

        //METODO DE BUSCA TOTAL, TODOS OS DADOS DA TABELA
        public DataTable Select()
        {
            ClienteDAO dao = new ClienteDAO(codCliente, razaoSocial, apelido);
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
