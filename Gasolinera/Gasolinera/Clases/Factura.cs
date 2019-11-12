using System;
using System.Collections.Generic;
using System.Text;

namespace Gasolinera.Clases
{
    public class Factura
    {
        public Factura(double subtotal, double iva, double total, Cliente cliente, Gasolina gasolina)
        {
            Subtotal = subtotal;
            IVA = iva;
            Total = total;
            Cliente = cliente;
            Gasolina = gasolina;
        }
        public Factura()
        {
        }
        private double subtotal;

        public double Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }

        private double iva;

        public double IVA
        {
            get
            {
                IVA = Subtotal * 0.12;
                return iva;
            }
            set { iva = value; }
        }

        private double total;

        public double Total
        {
            get
            {
                Total = Subtotal + IVA;
                return total;
            }
            set { total = value; }
        }

        private Cliente cliente;

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        private Gasolina gasolina;

        public Gasolina Gasolina
        {
            get { return gasolina; }
            set { gasolina = value; }
        }
    }
}
