using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Sistema
    {
        //Singleton
        private static Sistema _instancia = null;
        private Sistema()
        {
            Precarga();
        }

        public static Sistema GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new Sistema();
            }

            return _instancia;
        }

        private List<Serie> _series = new List<Serie>();
        private List<Cliente> _clientes = new List<Cliente>();
        private List<Compra> _compras = new List<Compra>();

        public List<Serie> GetSeries()
        {
            return _series;
        }
        public List<Compra> GetCompras()
        {
            return _compras;
        }
        public List<Cliente> GetClientes()
        {
            return _clientes;
        }

        public void AltaSerie(Serie serie)
        {
            try
            {
                serie.Esvalido();
                _series.Add(serie);
            }
            catch (Exception e)
            {
                
                throw e;
            }

        }
        public void AltaCliente(Cliente cliente)
        {
            try
            {
                cliente.EsValido();
                _clientes.Add(cliente);
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        public void AltaCompra(Compra compra)
        {
            try
            {
                compra.EsValido();
                _compras.Add(compra);
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        public List<Compra> GetComprasSuperen(double monto)
        {
            List<Compra> ret = new List<Compra>();
            foreach (Compra c in _compras)
            {
                if (c.PrecioFinal > monto)
                {
                    ret.Add(c);
                }
            }

            return ret;
        }

        private void Precarga()
        {
            Serie s1 = new Serie("Lost",121,1.2);
            Serie s2 = new Serie("Los Simpsons",600,0.8);
            Serie s3 = new Serie("Breaking Bad",70,1.4);

            AltaSerie(s1);
            AltaSerie(s2);
            AltaSerie(s3);

            Cliente c1 = new Cliente("Juan Perez","jperez@email.com",2);
            Cliente c2 = new Cliente("Ana Fernández","afernandez@email.com",2);

            AltaCliente(c1);
            AltaCliente(c2);

            Compra compra1 = new Compra(s1, c2);

            Compra compra2 = new Compra(s1, c1);
            Compra compra3 = new Compra(s2, c1);
            Compra compra4 = new Compra(s3, c2);

            AltaCompra(compra1);
            AltaCompra(compra2);
            AltaCompra(compra3);
            AltaCompra(compra4);



        }


    }
}
