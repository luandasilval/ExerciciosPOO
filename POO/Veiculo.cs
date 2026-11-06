namespace POO
{
    public class Veiculo
    {
        public int Velocidade { get; set; }

        public void AlterarVelocidade(int novaVelocidade)
        {
            if (novaVelocidade >= 0 && novaVelocidade <= 100)
            {
                Velocidade = novaVelocidade;
                Console.WriteLine($"A velocidade do veículo foi alterada para {Velocidade} km/h.");
            }
            else
            {
                Console.WriteLine("A velocidade é inválida");
                return;
            }
        }
    }
}