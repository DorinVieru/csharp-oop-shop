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

        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
