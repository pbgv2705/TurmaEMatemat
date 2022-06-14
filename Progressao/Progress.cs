using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progressao
{
    public abstract class Progress
    {
        public int Primeiro { get; set; }
        public int Razao { get; set; }
        public abstract  int ProximoValor
        {
            get;
            
        }

        public Progress(int primeiro, int razao)
        {
            Primeiro = primeiro;
            Razao = razao;
        }

        
        public void Reinicializar()
        {
            //proximoValor = primeiro;
        }
        public int TermoAt(int posicao)
        {
            return 0;
        }
    }
}
