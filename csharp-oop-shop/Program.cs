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

        // Metodo per ottenere il nome esteso del prodotto
        public string NomeEsteso()
        {
            return Codice + " " + Nome;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test della classe Prodotto
            Prodotto prodotto1 = new Prodotto("Il Signore degli Anelli: Il Ritorno del Re", "Uno dei libri più maestosi mai scritti. Se non lo hai ancora letto, sbrigati.", 33.50, 22.0);
            Prodotto prodotto2 = new Prodotto("Matrix", "Il film che ti mostra la realtà in cui vivi. Toc toc, Neo.", 22.0, 22.0);

            Console.WriteLine("Prodotto 1:");
            Console.WriteLine("Codice: " + prodotto1.Codice);
            Console.WriteLine("Nome: " + prodotto1.Nome);
            Console.WriteLine("Descrizione: " + prodotto1.Descrizione);
            Console.WriteLine("Prezzo base: " + prodotto1.PrezzoBase());
            Console.WriteLine("Prezzo con IVA: " + prodotto1.PrezzoConIVA());
            Console.WriteLine("Nome esteso: " + prodotto1.NomeEsteso());

            Console.WriteLine("\nProdotto 2:");
            Console.WriteLine("Codice: " + prodotto2.Codice);
            Console.WriteLine("Nome: " + prodotto2.Nome);
            Console.WriteLine("Descrizione: " + prodotto2.Descrizione);
            Console.WriteLine("Prezzo base: " + prodotto2.PrezzoBase());
            Console.WriteLine("Prezzo con IVA: " + prodotto2.PrezzoConIVA());
            Console.WriteLine("Nome esteso: " + prodotto2.NomeEsteso());
        }
    }
}
