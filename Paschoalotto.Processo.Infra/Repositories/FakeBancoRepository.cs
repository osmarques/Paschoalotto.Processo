using Nancy.Json;
using Newtonsoft.Json;
using Paschoalotto.Processo.Models;

namespace Paschoalotto.Processo.Infra.Repositories
{
    public class FakeRepository { 
        public void SalvarJson(ConfigProcesso configProcesso)
        {
        string Bjson = JsonConvert.SerializeObject(configProcesso);
        System.IO.File.WriteAllText(@"D:\objeto.json", Bjson);

        }
    }
}

