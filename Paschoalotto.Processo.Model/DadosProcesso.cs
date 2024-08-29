

using static System.Collections.Specialized.BitVector32;

namespace Paschoalotto.Processo.Models
{
    public class RequestProcesso
    {
        public double Divida { get; set; }
        public string Data_Vencimento { get; set; }
    }

    public class ResponseProcesso
    {
        public string data_vencimento { get; set; }
        public int quantidade_parcelas { get; set; }
        public double valor_original { get; set; }
        public double dias_atraso { get; set; }
        public double valor_juros { get; set; }
        public double valor_final { get; set; }
        public valor_final_parcela[] valor_final_parcela { get; set; }
        public string telefone_orientação { get; set; } = "014991261639";
    }
    public class valor_final_parcela
    {
        public int numero_parcela { get; set; }
        public double valor_parcela { get; set; }
        public string vencimento_parcela { get; set; }
    }
}
