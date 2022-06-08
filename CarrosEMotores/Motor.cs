using System.ComponentModel.DataAnnotations;

namespace CarrosEMotores
{
    public class Motor
    {
        [Required]
        public int CodigoMotor { get; set; }  // ID do motor
        [Required]
        public double Cilindrada { get; set; }
        public Carro Carro { get; set; }  
        public int Instalado { get; set; } // 0: Não instalado - 1: Instalado

        public Motor(int codigoMotor, double cilindrada, int instalado)
        {
            CodigoMotor = codigoMotor;
            Cilindrada = cilindrada;
            Instalado = instalado;
        }
    }
}
