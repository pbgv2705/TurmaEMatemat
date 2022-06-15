namespace Progressao
{
    internal class ProgressGeomet : Progress
    {
        public ProgressGeomet(int primeiro, int razao) : base(primeiro, razao)
        {
        }

        public override int ProximoValor
        {
            get
            {
                Primeiro *= Razao;
                return Primeiro;
            }
        }

        public string PG(int primeiro, int razao, int nroIterac)
        {
            int proximoValor = primeiro;
            string serie = $"Progressão Geométrica (inicia {primeiro}, razão {razao}, e {nroIterac} iterações): \n \n " +
                proximoValor.ToString();
            int proxVal = 0;
            for (int i = 1; i < nroIterac; i++)
            {
                proxVal = ProximoValor;
                serie += ", " + proxVal.ToString();
            }
            return serie;
        }
        public override int TermoAt(int posicao)
        {
            int termo = Convert.ToInt32(Primeiro * Math.Pow(Razao, (posicao - 1)));
            return termo;
        }
    }
}
