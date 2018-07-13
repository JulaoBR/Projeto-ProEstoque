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
    public class FornecedorControl
    {
        private FornecedorModel modelo;
        private string codFornecedor;
        private string razaoSocial;
        private string apelido;

        public FornecedorControl()
        {

        }

        public FornecedorControl(FornecedorModel model)
        {
            this.modelo = model;
        }

        public FornecedorControl(string codFornecedor, string razaoSocial, string apelido)
        {
            this.codFornecedor = codFornecedor;
            this.razaoSocial = razaoSocial;
            this.apelido = apelido;
        }

        //METODDO DE INSERIR
        public int Inserir()
        {
            FornecedorDAO dao = new FornecedorDAO(modelo);
            try
            {
                if (modelo.for_razao_social == "" )
                    //RETORNO DE 1 OBJETO NAO COMPLETO
                    return 0;

                if (ValidarFornecedor())
                    return 1;

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
            FornecedorDAO dao = new FornecedorDAO(modelo);
            try
            {
                if (modelo.for_cod == 0)
                    return 0;

                dao.Update();
                return 2;
            }
            catch
            {
                //RETORNO DE 3 ERRO NA OPERAÇÃO
                return 3;
            }            
        }

        //METODO DE BUSCA TOTAL, TODOS OS DADOS DA TABELA
        public DataTable Select()
        {
            FornecedorDAO dao = new FornecedorDAO(codFornecedor,  razaoSocial,  apelido);
            return dao.Select();
        }

        //RETORNA UM OBJETO DO TIPO UNIDADE DE MEDIDA
        public FornecedorModel SelectByID(int id)
        {
            FornecedorDAO dao = new FornecedorDAO();
            return dao.SelectByID(id);
        }

        public bool Excluir(string codigo)
        {
            FornecedorDAO dao = new FornecedorDAO();

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

        public bool ValidarFornecedor()
        {
            FornecedorDAO dao = new FornecedorDAO(modelo);
            if (dao.ValidaFornecdor() != null)
                //RETORNO DE 0 OBJETO JA EXISTE
                return true;

            return false;
        }
    }
}
