using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paschoalotto.Processo.Service.Helpers
{
    public class TratamentoJsonHelper
    {
        public static string SerializarObjetoResposta(object? resposta)
        {
            var serializerSettings = new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
            };

            return JsonConvert.SerializeObject(resposta, serializerSettings);
        }

        public static string SerializarObjetoGwLogGerenciamento(object? resposta)
        {
            var serializerSettings = new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Formatting = Formatting.Indented
            };

            return JsonConvert.SerializeObject(resposta, serializerSettings);
        }
    }
}
