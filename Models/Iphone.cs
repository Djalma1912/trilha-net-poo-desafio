namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"

    public class Iphone : Smartphone
    {
        public Iphone(string numero, string Modelo, string imei, string memoria, string v) : base(numero, Modelo)
        {
    
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
             Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone.");
        }
    }
}