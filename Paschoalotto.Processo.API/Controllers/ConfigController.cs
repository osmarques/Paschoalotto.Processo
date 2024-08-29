using Microsoft.AspNetCore.Mvc;
using Paschoalotto.Processo.Models;
using Paschoalotto.Processo.Models.DTO;
using Paschoalotto.Processo.Service.Service;


namespace Paschoalotto.Processo.API.Controllers
{
    [Route("v1/api/config")]
    [ApiController]
    public class ConfigProcessoController : ControllerBase
    {
        private readonly ConfigProcessoService configProcessoService = new();

        /// <summary>
        /// Inserir registro de informação do processo.
        /// </summary>
        /// <param name="configProcesso">informação do processo.</param>
        /// <returns>dados inseridos.</returns>
        [HttpPut]
        public IActionResult Put([FromBody] ConfigProcesso configProcesso)
        {
            var retorno = configProcessoService.SaveConfig(configProcesso);
            var resposta = new APIRetornoDTO<ConfigProcesso>();

            try
            {
                resposta.Mensagem = "Cadastrado com sucesso!";

                return Ok(retorno);
            }
            catch (Exception ex)
            {
                resposta.OcorreuErro = true;
                resposta.Mensagem = $@"Deu ruim: {ex.Message}";

                return BadRequest(resposta);
            }
        }
        /// <summary>
        /// Busca as informações do proceso através do parametro
        /// </summary>
        /// <param name="dadosprocessoId"></param>
        /// <returns>Uma mensagem</returns>
        [HttpGet()]
        public IActionResult Get()
            {
            var retorno = configProcessoService.GetConfig();
            var resposta = new APIRetornoDTO<ConfigProcesso>();
            try
            {
                resposta.Retorno = retorno;
                resposta.Mensagem = "Cadastrado com sucesso!";

                return Ok(retorno);
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


