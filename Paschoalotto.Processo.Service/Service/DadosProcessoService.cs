using Paschoalotto.Processo.Models;
using Paschoalotto.Processo.Service.Service;

namespace Paschoalotto.Processo.Services
{
    public class DadosProcessoService
    {
        public ConfigProcessoService ConfigCalculo { get; set; } = new ConfigProcessoService();
        public ResponseProcesso Calcular(RequestProcesso dadosProcesso)
        {
            string dataInicial = dadosProcesso.Data_Vencimento;
            string dataFinal = DateTime.Now.ToString("dd/MM/yyyy");
            TimeSpan date = Convert.ToDateTime(dataFinal) - Convert.ToDateTime(dataInicial);

            var config = ConfigCalculo.GetConfig();

            var list_valor_final_parcela = new List<valor_final_parcela>();

            for (int i = 0; i < config.quantidade_max_parcelas; i++)
            {
                list_valor_final_parcela.Add(new valor_final_parcela()
                {
                    numero_parcela = i,
                    valor_parcela = Math.Round((dadosProcesso.Divida + (config.juros / 100) * dadosProcesso.Divida * date.Days) / config.quantidade_max_parcelas, 2),
                    vencimento_parcela = DateTime.Now.AddMonths(i).ToString("dd/MM/yyyy")
                });
            }

            var dadosProcessoAtual = new ResponseProcesso()
            {
                data_vencimento = dadosProcesso.Data_Vencimento.ToString(),
                quantidade_parcelas = config.quantidade_max_parcelas,
                valor_original = Math.Round(dadosProcesso.Divida, 2),
                dias_atraso = date.Days,
                valor_juros = Math.Round((config.juros / 100) * dadosProcesso.Divida * date.Days, 2),
                valor_final = Math.Round(dadosProcesso.Divida + (config.juros / 100) * dadosProcesso.Divida * date.Days, 2),
                valor_final_parcela = list_valor_final_parcela.ToArray(),
            };

            return dadosProcessoAtual;
        }
    }
}
