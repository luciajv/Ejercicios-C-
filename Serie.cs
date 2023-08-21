using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dominio
{
    public class Serie
    {
        private static int _ultimoId = 1;
        public int Id { get; set; }     
        public string Nombre { get; set; }     
        public int CantidadCapitulos { get; set; }     
        public double PrecioCapitulo { get; set; }

        public Serie()
        {
            
        }

        public Serie(string nombre, int cantidadCapitulos, double precioCapitulo)
        {
            Id = _ultimoId++;
            Nombre = nombre;
            CantidadCapitulos = cantidadCapitulos;
            PrecioCapitulo = precioCapitulo;
        }

        public void Esvalido()
        {
            if (Nombre == "")
            {
                throw new Exception("nombre no valido");
            }

            if (CantidadCapitulos <= 0)
            {
                throw new Exception("cantidad capitulos no valido");
            }
        }

        public double CalcularPrecio()
        {
            return PrecioCapitulo * CantidadCapitulos;
        }
    }

  
}
