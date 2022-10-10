using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Paschoalotto.Processo.Infra.Repositories;
using Paschoalotto.Processo.Models;
using Paschoalotto.Processo.Models.DTO;
using Paschoalotto.Processo.Service.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Paschoalotto.Processo.Service.Service
{
    public class ConfigProcessoService
    {
        public FakeRepository DadosProcessoRepository { get; set; } = new FakeRepository();
        public ConfigProcesso GetConfig()
        {
       
            var resposta = new APIRetornoDTO<ConfigProcesso>();
            StreamReader r = new StreamReader(@"C:\objeto.json");
            string json = r.ReadToEnd();
            
            var Bjson = JsonConvert.DeserializeObject<ConfigProcesso>(json);
            r.Close();

            return Bjson;
        }
        public ConfigProcesso SaveConfig(ConfigProcesso configProcesso)
        {
            File.Delete(@"C:\objeto.json");
            DadosProcessoRepository.SalvarJson(configProcesso);
            return configProcesso;
        }

    }
}
