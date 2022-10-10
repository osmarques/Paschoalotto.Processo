using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paschoalotto.Processo.Models
{
    public class ConfigProcesso
    {
        public int quantidade_max_parcelas { get; set; }
        public string tipo_juros { get; set; }
        public double juros { get; set; }
        public double comissao_paschoalotto { get; set; }

    }
}
