using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_POO_Sebastian_Florez
{
    internal class Program
    {
        public class Habitacion
        {
            private int numero;
            private string tipo;
            private decimal precioPorNoche;
            private bool ocupada;
            private string nombreHuesped;

            public Habitacion(int numero, string tipo, decimal precioPorNoche)
            {
                this.numero = numero;
                this.tipo = tipo;
                this.precioPorNoche = precioPorNoche;
                this.ocupada = false;
                this.nombreHuesped = "Ninguno";
            }

            public int Numero => numero;
            public decimal PrecioPorNoche => precioPorNoche;
            public bool Ocupada => ocupada;

            public void Reservar(string huesped)
            {
                ocupada = true;
                nombreHuesped = huesped;
            }

            
            public void AplicarDescuento(int porcentaje)
            {
                decimal nuevoPrecio = precioPorNoche - (precioPorNoche * (porcentaje / 100m));
                if (nuevoPrecio <= 0)
                {
                    Console.WriteLine($"[Aviso] El descuento deja la habitación {numero} en cero o negativo. No aplicado.");
                }
                else
                {
                    precioPorNoche = nuevoPrecio;
                }
            }

            
            public string ObtenerDatosResumen()
            {
                string estado = ocupada ? $"Ocupada por: {nombreHuesped}" : "Libre";
                return $"[{numero}] {tipo} - ${precioPorNoche:N0} - {estado}";
            }
        }

        public static void Main(string[] args)
        {
            
            List<Habitacion> habitaciones = new List<Habitacion> {
                new Habitacion(101, "Individual", 50000),
                new Habitacion(102, "Doble", 90000),
                new Habitacion(201, "Suite", 180000)
            };

            
            habitaciones[0].Reservar("Sebastian Florez");
            habitaciones[1].AplicarDescuento(10);

            
            foreach (Habitacion h in habitaciones)
            {
                Console.WriteLine(h.ObtenerDatosResumen());
            }

            
            int libres = 0;
            int ocupadas = 0;
            foreach (Habitacion h in habitaciones)
            {
                if (h.Ocupada) ocupadas++;
                else libres++;
            }

            decimal suma = 0;
            foreach (Habitacion h in habitaciones)
            {
                suma += h.PrecioPorNoche;
            }
            decimal promedio = habitaciones.Count > 0 ? suma / habitaciones.Count : 0;

            
            Console.WriteLine($"\nHabitaciones libres: {libres}[span_2](start_span)[span_2](end_span)");
            Console.WriteLine($"Habitaciones ocupadas: {ocupadas}[span_3](start_span)[span_3](end_span)");
            Console.WriteLine($"Precio promedio: ${promedio:N0}[span_4](start_span)[span_4](end_span)");
        }
    }
}
