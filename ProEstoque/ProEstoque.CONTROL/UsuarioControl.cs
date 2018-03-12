using ProEstoque.DAO;
using ProEstoque.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEstoque.CONTROL
{
    public class UsuarioControl
    {
        public UsuarioControl()
        {

        }

        public void Inserir(UsuarioModel usuario)
        {
            UsuarioDAO dao = new UsuarioDAO();

            dao.Insert(usuario);
        }
    }
}
