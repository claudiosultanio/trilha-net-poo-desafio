namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
    public Nokia(string numero,string modelo,string imei,int memoria) : base (numero,modelo,imei,memoria)
    {
        
    }
            
            // TODO: Sobrescrever o método "InstalarAplicativo"
            public override void InstalarAplicativo(string maps)
            {
                Console.WriteLine($"Instalando Aplicativo {maps} no Nokia...");
                Console.WriteLine($"{maps} instalado com sucesso!");
            }
        } 
} 
  