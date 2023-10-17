namespace Decorator
{
    public class SistemaSonido : IComponente
    {
        //Variable de referencia hacia quien decoramos:
        private readonly IComponente _decoramosA;

        //pasamos al objeto que va a ser decorado:
        public SistemaSonido(IComponente componente)
        {
            _decoramosA = componente;
        }

        public override string ToString()
        {
            return "Spotify MyList+\r\n" + _decoramosA.ToString();
        }

        //Metodos de la interfaz:
        public double Costo()
        {
            return _decoramosA.Costo() + 3500;
        }

        public string Funciona()
        {
            return _decoramosA.Funciona() + "Enciendo my playlist";
        }
    }
}
