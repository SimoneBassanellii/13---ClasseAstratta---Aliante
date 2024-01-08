using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___OGGETTI_UML___Aliante
{
    internal class Ruota : Composite
    {
        private Gomma _gomma;
        private Cerchione _cerchione;

        public Gomma Gomma
        {
            get { return _gomma; }
            set { _gomma = value; }
        }

        public Cerchione Cerchione
        {
            get { return _cerchione; }
            set { _cerchione = value; }
        }

        public Ruota()
        {
            Gomma = new Gomma();
            Cerchione = new Cerchione();
        }

        public Ruota(Gomma gomma, Cerchione cerchione)
        {
            Gomma = gomma;
            Cerchione = cerchione;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Ruota) || obj == null)
            {
                return false;
            }

            Ruota other = (Ruota)obj;
            return Gomma.Equals(other.Gomma) && Cerchione.Equals(other.Cerchione);
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
            return "Particolari gomma: " + Gomma + " Particolari cerchione " + Cerchione;
        }

        public override double Price()
        {
            return 0;
        }
    }




}
