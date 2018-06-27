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
        public int pro_cod_original { get; set; }
        public int tipo_cod { get; set; }
        public int uni_cod { get; set; }
        public string pro_descricao { get; set; }
        public int pro_prazo_validade { get; set; }
        public decimal pro_peso_liquido { get; set; }
        public decimal pro_peso_bruto { get; set; }
        public decimal pro_estoque_minimo { get; set; }
        public decimal pro_estoque_maximo { get; set; }
        public string pro_cod_barra { get; set; }
    }
}
