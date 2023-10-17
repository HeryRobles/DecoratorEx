namespace Decorator
{
    public class Nitrogeno : IComponente
    {
        //Variable de referencia hacia quien decoramos:
        private readonly IComponente _decoramosA;

        //Pasamos al objeto que va a ser decorado:
        public Nitrogeno(IComponente componente)
        {
            
            _decoramosA = componente;
        }
        public override string ToString()
        {
            return "Sistema de Nitrogeno\r\n" + _decoramosA.ToString();
        }

        //Metodos de la interfaz:
        public double Costo()
        {
            //Calculamos el costo
            //El costo de lo que decoro, mas el costo de mi componente:
            return _decoramosA.Costo() + 45000; 
        }

        public string Funciona()
        {
            return _decoramosA.Funciona() + ", Nitrogeno listo"; 
        }

        public void UsaNitrogeno()
        {
            Console.WriteLine("Nitrogeno en uso");
        }
    }
}
