using ProEstoque.DAO;
using ProEstoque.MODEL;
using System;
using System.Collections.Generic;
using System.Data;

namespace ProEstoque.CONTROL
{
    public class MotivoControl
    {
        public MotivoControl()
        {

        }

        //METODDO DE INSERIR
        public bool Inserir(MotivoModel motivo)
        {
            MotivoDAO dao = new MotivoDAO();

            //VERIFICA SE TEM DADOS DENTRO DO OBJETO
            if (motivo.mot_descricao != string.Empty)
            {
                dao.Insert(motivo);
                //SE DER TUDO CERTO RETORNA TRUE
                return true;
            }
            else
            {
                //SE NAO RETORNA FALSE
                return false;
            }
        }

        public bool Update(MotivoModel motivo)
        {
            MotivoDAO dao = new MotivoDAO();

            if (motivo.mot_cod != 0 || motivo.mot_descricao != string.Empty)
            {
                dao.Update(motivo);
                return true;
            }
            else
            {
                return false;
            }
        }

        //METODO DE BUSCA TOTAL, TODOS OS DADOS DA TABELA
        public DataTable Select()
        {
            MotivoDAO dao = new MotivoDAO();
            return dao.Select();
        }

        //RETORNA UM OBJETO DO TIPO UNIDADE DE MEDIDA
        public MotivoModel SelectByID(int id)
        {
            MotivoDAO dao = new MotivoDAO();
            return dao.SelectByID(id);
        }

        public bool Excluir(string codigo)
        {
            MotivoDAO dao = new MotivoDAO();

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
