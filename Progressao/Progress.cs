namespace Progressao
{
    public abstract class Progress
    {
        public int Primeiro { get; set; }
        public int Razao { get; set; }
        public abstract int ProximoValor
        {
            get;

        }

        public Progress(int primeiro, int razao)
        {
            Primeiro = primeiro;
            Razao = razao;
        }

        public void  Reinicializar(string tipo, int iteracoes)
        {
            string str_PA = "PA", str_PG = "PG";

            if (tipo.Equals(str_PA))
            {
                Primeiro -= (iteracoes - 1) * Razao;
                Console.WriteLine("Primeiro na Progressão Aritmética reinicializado no valor: " + Primeiro);
            }else if (tipo.Equals(str_PG))
            {
                Primeiro = Convert.ToInt32(Primeiro / Math.Pow(Razao,iteracoes - 1));
                Console.WriteLine("Primeiro na Progressão Geométrica reinicializado no valor: " + Primeiro);
            }
        }
        public abstract int TermoAt(int posicao);
    }
}
