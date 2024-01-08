using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___OGGETTI_UML___Aliante
{
    internal class Fusoliera : Composite
    {
        private double _lunghezza;
        private string _materiale;

        public double Lunghezza
        {
            get { return _lunghezza; }
            set
            {
                if (value >= 60)
                    _lunghezza = value;
                else
                    _lunghezza = 60;
            }
        }

        public string Materiale
        {
            get { return _materiale; }
            set { _materiale = value; }
        }

        public Fusoliera(double lunghezza, string materiale)
        {
            Lunghezza = lunghezza;
            Materiale = materiale;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Fusoliera) || obj == null)
            {
                return false;
            }

            Fusoliera other = (Fusoliera)obj;
            return Lunghezza == other.Lunghezza && Materiale == other.Materiale;
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
            return "Fusoliera: " + Lunghezza + "m";
        }

        public override double Price()
        {
            return 50 * Lunghezza;
        }
    }
}
