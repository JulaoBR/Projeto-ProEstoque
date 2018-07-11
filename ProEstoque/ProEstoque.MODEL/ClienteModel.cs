using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEstoque.MODEL
{
    public class ClienteModel
    {
        public ClienteModel()
        {

        }

        public int cli_cod { get; set; }
        public int est_cod { get; set; }
        public string est_nome { get; set; }
        public int cid_cod { get; set; }
        public string cid_nome { get; set; }
        public string cli_nome_social { get; set; }
        public string cli_nome_fantasia { get; set; }
        public string cli_endereco { get; set; }
        public string cli_bairro { get; set; }
        public string cli_numero { get; set; }
        public string cli_cep { get; set; }
        public string cli_tipo_pessoa { get; set; }
        public DateTime cli_data_cadastro { get; set; }
    }
}
