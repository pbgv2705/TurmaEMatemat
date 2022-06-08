using System.ComponentModel.DataAnnotations;

namespace CarrosEMotores
{
    public class Carro
    {
        [Required]
        public string Placa { get; set; }
        [Required]
        public string Modelo { get; set; }
        public Motor Motor { get; set; }

        public Carro(string placa, string modelo, Motor motor)
        {

            this.Placa = placa;
            this.Modelo = modelo;
            this.Motor = motor;
            motor.Carro = this;
        }
        public bool TrocarMotor(Motor motor)
        {
            // Pesquisar se o motor está instalado num outro carro. Caso sim, gerar exceção
            if (motor.Instalado == 1)
            {
                throw new Exception($"O motor {Motor.CodigoMotor} está instalado em outro carro");
            }
            else
            {
                this.Motor.Instalado = 1;
                this.Motor = motor;
                return true;
            }
        }
        public string CalculaVelocidad()
        {
            if (Motor.Cilindrada == 1.0)
                return $"A velocidade máxima do carro {Placa} é: " + (decimal)VelocidadeMax.CentoQuarenta;
            else if (Motor.Cilindrada == 1.6)
                return $"A velocidade máxima do carro {Placa} é: " + (decimal)VelocidadeMax.CentoSessenta;
            else if (Motor.Cilindrada == 2.0)
                return $"A velocidade máxima do carro {Placa} é: " + (decimal)VelocidadeMax.CentoOitenta;
            else 
                return $"A velocidade máxima do carro {Placa} é: " + (decimal)VelocidadeMax.DuzentosVinte;
        }
    }
}
