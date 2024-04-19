namespace csharp_oop_shop
{
    
    public class Prodotto
    {
        private int _codice;
        public int Codice { get { return _codice; } }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }
        public double IVA { get; set; }

        // Costruttore che genera un codice casuale per il prodotto
        public Prodotto(string nome, string descrizione, double prezzo, double iva)
        {
            Nome = nome;
            Descrizione = descrizione;
            Prezzo = prezzo;
            IVA = iva;
            GeneraCodice();
        }

        // Metodo privato per generare un codice casuale per il prodotto
        private void GeneraCodice()
        {
            Random cod = new Random();
            _codice = cod.Next(1000, 10000);
        }

        // Metodo per ottenere il prezzo base del prodotto
        public double PrezzoBase()
        {
            return Prezzo;
        }

        // Metodo per ottenere il prezzo comprensivo di IVA del prodotto
        public double PrezzoConIVA()
        {
            return Prezzo + (Prezzo * IVA / 100);
        }

        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
