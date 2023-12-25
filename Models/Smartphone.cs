namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public Smartphone (string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            _modelo = modelo;
            Imei = imei;
            _memoria = memoria;
        }
        public string Numero { get; set; }
        private string _modelo;
        private string _imei;
        private int _memoria;

        protected string Modelo => _modelo.ToUpper();
        protected string Imei 
        {
            get {return _imei;}
            set
            {
                try
                {
                    if(value.Length==15)
                    {
                        _imei = value;
                    }
                    else
                    {
                        throw new ArgumentException("O IMEI deve conter 15 dígitos");
                    }
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }
            }
        
        }
        protected int Memoria=> _memoria;

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }
        public abstract void InstalarAplicativo(string nomeApp);

        public void ExibirDataEHora()
        {
            DateTime data = DateTime.Now;
            Console.WriteLine($"Hoje é {data.ToShortDateString()} e são {data.ToShortTimeString()}.");
        }
        
    }
}