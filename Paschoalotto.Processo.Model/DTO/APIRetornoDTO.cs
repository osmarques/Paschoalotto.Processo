using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paschoalotto.Processo.Models.DTO
{
    public class APIRetornoDTO<ClasseRetorno>
    {
        public ClasseRetorno Retorno { get; set; }
        public string Mensagem { get; set; }

        public bool OcorreuErro { get; set; } = false;
    }
}
