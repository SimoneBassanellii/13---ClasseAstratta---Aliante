using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace _13___OGGETTI_UML___Aliante
{
    public class Ala : Composite
    {
        private double _lunghezza;
        private double _apertura;

        public double Lunghezza
        {
            get { return _lunghezza; }
            set
            {
                if (value >= 10)
                    _lunghezza = value;
                else
                    _lunghezza = 10;
            }
        }

        public double Apertura
        {
            get { return _apertura; }
            set
            {
                if (value >= 2)
                    _apertura = value;
                else
                    _apertura = 2;
            }
        }

        public Ala(double lunghezza, double apertura)
        {
            Lunghezza = lunghezza;
            Apertura = apertura;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Ala) || obj == null)
            {
                return false;
            }

            Ala other = (Ala)obj;
            return Lunghezza == other.Lunghezza && Apertura == other.Apertura;
        }

        public override void Add(Composite component)
        {

        }

        public override void Remove(Composite component)
        {

        }

        public override Composite GetChild(int index)
        {
            return null;
        }

        public override string ToString()
        {
            return $"Lunghezza ala: {Lunghezza}; Apertura ala: {Apertura}";
        }

        public override double Price()
        {
            return Lunghezza * Apertura;

        }
    }
}
