namespace Progressao
{
    public class ProgressAritm : Progress
    {
        public ProgressAritm(int primeiro, int razao) : base(primeiro, razao)
        {
        }

        public override int ProximoValor
        {
            get
            { 
                Primeiro += Razao;
                return Primeiro;
            } 
        }

        public string PA (int primeiro, int razao, int nroIterac) 
        {
            int proximoValor = primeiro;
            string serie = $"Progressão Aritmetica (inicia {primeiro}, razão {razao}, e {nroIterac} iterações): \n \n " + proximoValor.ToString();
            int proxVal = 0;
            for (int i = 1; i < nroIterac; i++)
            {
                proxVal = ProximoValor;
                serie += ", " + proxVal.ToString();
            }
            return serie;
        }
        

    }
}

