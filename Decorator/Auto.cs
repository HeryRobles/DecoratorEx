namespace Decorator
{
    /*Esta clase representa al componente y debe de implementar a IComponente
     * para poder llevar a cabo la decoración...*/

    public class Auto : IComponente
    {
        private readonly string _modelo;
        private readonly string _caracteristicas;
        private readonly double _costo;

        public Auto(string modelo, string caracteristicas, double costo)
        {
            _modelo = modelo;
            _caracteristicas = caracteristicas;
            _costo = costo;
        }

        //PROPIEDADES PROPIAS DEL AUTO:
        public void Puertas(bool estado)
        {
            if(estado)
            {
                Console.WriteLine("Las puertas están abiertas");
            }else
            { Console.WriteLine("Las puertas están cerradas"); }
        }

        public override string ToString()
        {
            return string.Format("Modelo {0}, {1} \r\n", _modelo, _caracteristicas);
        }


        public double Costo()
        {
            return _costo;
        }

        public string Funciona()
        {
            return "Encendí el auto"; 
        }
    }
}
