using System;
using System.Collections.Generic;
using System.Text;

namespace Gasolinera.Clases
{
    public class Gasolina
    {
        public Gasolina(string tipo, int cantidadGalones, double precio)
        {
            Tipo = tipo;
            CantidadGalones = cantidadGalones;
            Precio = precio;
        }

        public Gasolina()
        {
        }

        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private double cantidadGalones;

        public double CantidadGalones
        {
            get { return cantidadGalones; }
            set { cantidadGalones = value; }
        }

        private double precio;

        public double Precio
        {
            get
            {
                return precio;
            }
            set { precio = value; }
        }

        private Factura factura;

        public Factura Factura
        {
            get { return factura; }
            set { factura = value; }
        }
    }
}
