using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEstoque.MODEL
{
    public class ProdutoModel
    {
        public int pro_cod { get; set; }
        public int tipo_cod { get; set; }
        public int uni_cod { get; set; }
        public string pro_descricao { get; set; }
        public int pro_prazo_validade { get; set; }
    }
}
