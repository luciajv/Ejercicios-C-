using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Compra
    {
        private static int _ultimoId = 0;
        public int Id { get; set; }
        public Serie Serie { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public double PrecioFinal { get; set; }
        public bool Cerrada { get; set; }

        public Compra( Serie serie, Cliente cliente)
        {
            Id = _ultimoId++;
            Serie = serie;
            Cliente = cliente;
            Fecha = DateTime.Now;
            Cerrada = false;
            CalcularYFijarPrecio();
        }
        public Compra()
        {

        }

        public void EsValido()
        {
            if (Serie == null || Cliente == null)
            {
                throw new Exception("faltan datos");
            }
        }

        public void CalcularYFijarPrecio()
        {
            if (!Cerrada)
            {
                PrecioFinal = Serie.CalcularPrecio();
                Cerrada = true;
            }


        }
    }
}
