namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {        
        // feat: Implementar as propriedades faltantes de acordo com o diagrama
        public string Numero { get; set; }
        public string Modelo {get; private set; }
        public string IMEI {get; private set; }
        public int Memoria {get; private set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            // feat: Passar os parâmetros do construtor para as propriedades
            Numero = numero;
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