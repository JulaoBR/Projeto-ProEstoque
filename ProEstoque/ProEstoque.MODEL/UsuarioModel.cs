using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEstoque.MODEL
{
    public class UsuarioModel
    {
        public UsuarioModel()
        {

        }

        public int usu_cod { set; get; }
        public string usu_nome { set; get; }
        public string usu_telefone { set; get; }
        public string usu_login { set; get; }
        public string usu_senha { set; get; }
    }   
}
