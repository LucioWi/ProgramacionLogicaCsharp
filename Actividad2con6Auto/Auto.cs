using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2con6Auto
{
    public class Auto
    {
        private string marca = "";
        private string modelo = "";
        private double combustibleActual = 0;
        private double capacidadTanque = 49;
        private double reserva = 5;
        private double rendimiento = 11;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public double CombustibleActual
        {
            get { return combustibleActual; }
            set { combustibleActual = value; }
        }

        public double CapacidadTanque
        {
            get { return capacidadTanque; }
            set { capacidadTanque = value; }
        }

        public double Reserva
        {
            get { return reserva; }
            set { reserva = value; }
        }

        public double Rendimiento
        {
            get { return rendimiento; }
            set { rendimiento = value; }
        }
        public Auto()
        {
            marca = "Sin marca";
            modelo = "Sin modelo";
            combustibleActual = 0;
        }

        public Auto(string marca, string modelo, double combustibleInicial)
        {
            this.marca = marca;
            this.modelo = modelo;

            double capacidadTotal = capacidadTanque + reserva;
            if (combustibleInicial <= capacidadTotal)
                combustibleActual = combustibleInicial;
            else
                combustibleActual = capacidadTotal;
        }

        public string Conducir(double kilometros)
        {
            double combustibleNecesario = kilometros / rendimiento;

            if (combustibleNecesario <= combustibleActual)
            {
                combustibleActual -= combustibleNecesario;
                return $"Recorrido completado. Combustible restante: {combustibleActual:F2} lts.";
            }
            else
            {
                return "No hay combustible suficiente para el recorrido indicado.";
            }
        }

        public double CargarCombustible(double litros)
        {
            double capacidadTotal = capacidadTanque + reserva;
            double nuevoTotal = combustibleActual + litros;

            if (nuevoTotal <= capacidadTotal)
            {
                combustibleActual = nuevoTotal;
                return 0;
            }
            else
            {
                double derramado = nuevoTotal - capacidadTotal;
                combustibleActual = capacidadTotal;
                return derramado;
            }
        }

        public override string ToString()
        {
            return $"Marca: {marca}\nModelo: {modelo}\nCombustible actual: {combustibleActual:F2} lts\n" + $"Capacidad total (incl. reserva): {capacidadTanque + reserva} lts\nRendimiento: {rendimiento} km/l";
        }
    }
}