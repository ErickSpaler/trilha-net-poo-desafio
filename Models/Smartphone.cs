using System.Linq;
namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        protected string numero;
        protected string modelo;
        protected string imei;
        protected int memoria;

        public string Numero
        {
            get => numero;

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O número não pode ser vazio.");
                }
                numero = value;
            }
        }

        protected string Modelo
        {
            get => modelo.ToUpper();

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O modelo não pode ser vazio.");
                }
                modelo = value;
            }
        }

        protected string IMEI
        {
            get => imei;

            set
            {
                if (value.All(char.IsDigit))
                {
                    imei = value;
                }
                else
                {
                    throw new ArgumentException("O campo IMEI só deve receber números.");
                }
            }
        }

        protected int Memoria
        {
            get => memoria;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("A memória não pode ser vazia.");
                }
                memoria = value;
            }
        }


        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
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