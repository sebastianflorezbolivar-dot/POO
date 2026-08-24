namespace Clase_4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Automovil miAuto = new Automovil();

            miAuto.Marca = "Toyota";
            miAuto.Modelo = "XL";
            miAuto.Anio = 2020;
            miAuto.VelocidadActual = 0;

            miAuto.MostrarInformacion();
        }

        public class Automovil
        {

            // Atributos
            public string Marca;
            public string Modelo;
            public int Anio;
            public double VelocidadActual;

            // Métodos
            public void Acelerar(double inc) { VelocidadActual += inc; }
            public void Frenar(double dec)
            {
                if (VelocidadActual - dec >= 0) VelocidadActual -= dec;
                else VelocidadActual = 0;
            }
            public void MostrarInformacion()
            {
                Console.WriteLine($"Marca: {Marca}");
                Console.WriteLine($"Modelo: {Modelo}");
                Console.WriteLine($"Año: {Anio}");
                Console.WriteLine($"Velocidad actual: {VelocidadActual} km/h");
            }






        } 
}   }
