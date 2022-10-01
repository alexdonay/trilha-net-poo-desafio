namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string Numero, string Modelo, string IMEI, int Memoria) : base(Numero, Modelo, IMEI, Memoria)
        {
            
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            System.Console.WriteLine($"Instalando aplicativo Nokia {nomeApp}");
        }
    }
}