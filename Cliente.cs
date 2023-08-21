using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente
    {
        private static int _ultimoId = 1;
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string Email { get; set; }
        public int NivelSuscripcion { get; set; }

        public Cliente()
        {
            
        }

        public Cliente(string nombreCompleto, string email, int nivelSuscripcion)
        {
            Id = _ultimoId++;
            NombreCompleto = nombreCompleto;
            Email = email;
            NivelSuscripcion = nivelSuscripcion;
        }

        public void EsValido()
        {
            if (NombreCompleto.Length < 3)
            {
                throw new Exception("nombre no valido");
            }

            if (NivelSuscripcion < 1 || NivelSuscripcion > 3)
            {
                throw new Exception("nivel no valido");
            }

            if (Email.IndexOf("@") <= 0 || Email.IndexOf("@") == Email.Length - 1)
            {
                throw new Exception("email no valido");
            }
        }
    }
}
