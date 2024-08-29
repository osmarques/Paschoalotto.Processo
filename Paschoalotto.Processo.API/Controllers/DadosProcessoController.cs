using Microsoft.AspNetCore.Mvc;
using Paschoalotto.Processo.Models;
using Paschoalotto.Processo.Models.DTO;
using Paschoalotto.Processo.Service.Service;
using Paschoalotto.Processo.Services;

namespace Paschoalotto.Processo.API.Controllers
{
    [Route("v1/api/calculo")]
    [ApiController]
    public class CalculoProcessoController : ControllerBase
    {
        private readonly DadosProcessoService DadosProcessoService = new();

        /// <summary>
        /// Inserir registro de informação do processo.
        /// </summary>
        /// <param name="dadosProcesso">informação do processo.</param>
        /// <returns>dados inseridos.</returns>
        [HttpPost]
        public IActionResult Post([FromBody] RequestProcesso RequestProcesso)
        {
            
            var resposta = new APIRetornoDTO<ResponseProcesso>();
            try
            {
                resposta.Retorno = DadosProcessoService.Calcular(RequestProcesso);
                resposta.Mensagem = "Cadastrado com sucesso!";

                return Ok(resposta);
            }
            catch (Exception ex)
            {
                resposta.OcorreuErro = true;
                resposta.Mensagem = $@"Deu ruim: {ex.Message}";

                return BadRequest(resposta);
            }
        }
    }
}

