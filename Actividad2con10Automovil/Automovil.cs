using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2con10Automovil
{
    public class Automovil
    {
        private Tanque tanque;
        private const double kmPorLitro = 11.0;

        public Tanque Tanque
        {
            get { return tanque; }
            set { tanque = value; }
        }

        public Automovil()
        {
            Tanque = new Tanque();
        }

        public Automovil(double combustibleInicial)
        {
            Tanque = new Tanque(combustibleInicial);
        }

        public void Conducir(double kilometros)
        {
            double litrosNecesarios = kilometros / kmPorLitro;

            if (Tanque.ConsumirCombustible(litrosNecesarios))
            {
                Console.WriteLine($"Recorrido exitoso de {kilometros} km. Combustible restante: {Tanque.CombustibleActual} litros.");
            }
            else
            {
                Console.WriteLine("No hay combustible suficiente para el recorrido indicado.");
            }
        }

        public void CargarCombustible(double litros)
        {
            double derramado = Tanque.CargarCombustible(litros);
            if (derramado > 0)
            {
                Console.WriteLine($"Se derramaron {derramado} litros de combustible.");
            }
            else
            {
                Console.WriteLine("Carga de combustible realizada exitosamente.");
            }
        }

        public void ChequearCombustible()
        {
            Console.WriteLine(Tanque.ChequearNivel());
        }

        public override string ToString()
        {
            return Tanque.ToString();
        }
    }
}
