using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEstoque.MODEL
{
    public class FornecedorModel
    {
        public FornecedorModel()
        {

        }

        public int for_cod { get; set; }
        public string for_razao_social { get; set; }
        public string for_apelido { get; set; }
        public string for_cnpj { get; set; }
        public DateTime for_data_cadastro { get; set; }

    }
}
