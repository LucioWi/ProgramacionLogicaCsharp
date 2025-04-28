using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2con10Automovil
{
    public class Tanque
    {
        private double capacidadMaxima; // 49 + 5 = 54 litros
        private double combustibleActual;

        public double CapacidadMaxima
        {
            get { return capacidadMaxima; }
            private set { capacidadMaxima = value; }
        }

        public double CombustibleActual
        {
            get { return combustibleActual; }
            private set { combustibleActual = value; }
        }

        public Tanque()
        {
            CapacidadMaxima = 54; // 49 normales + 5 de reserva
            CombustibleActual = 0;
        }

        public Tanque(double combustibleInicial)
        {
            CapacidadMaxima = 54;
            CombustibleActual = Math.Min(combustibleInicial, CapacidadMaxima);
        }

        public double CargarCombustible(double litros)
        {
            double espacioDisponible = CapacidadMaxima - CombustibleActual;
            if (litros <= espacioDisponible)
            {
                CombustibleActual += litros;
                return 0;
            }
            else
            {
                CombustibleActual = CapacidadMaxima;
                return litros - espacioDisponible; // litros derramados
            }
        }

        public bool ConsumirCombustible(double litros)
        {
            if (litros <= CombustibleActual)
            {
                CombustibleActual -= litros;
                return true;
            }
            else
            {
                return false;
            }
        }

        public string ChequearNivel()
        {
            double porcentaje = (CombustibleActual / CapacidadMaxima) * 100;

            if (CombustibleActual <= 5) // Reserva
            {
                return "ALERTA: Nivel en reserva. Reponer combustible de inmediato.";
            }
            else if (porcentaje <= 25)
            {
                return "Nivel de combustible: 25%";
            }
            else if (porcentaje <= 50)
            {
                return "Nivel de combustible: 50%";
            }
            else if (porcentaje <= 75)
            {
                return "Nivel de combustible: 75%";
            }
            else
            {
                return "Nivel de combustible: Lleno";
            }
        }

        public override string ToString()
        {
            return $"Combustible actual: {CombustibleActual} litros / {CapacidadMaxima} litros de capacidad.";
        }
    }
}
