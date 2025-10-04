namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // Propriedades faltantes implementadas
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        // Construtor ajustado para receber todos os parâmetros
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // Parâmetros do construtor passados para as propriedades
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}