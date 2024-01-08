using _13___OGGETTI_UML___Aliante;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___ClasseAstratta___Aliante
{
    internal class Aliante : Composite
    {
        private List<Composite> _parti;

        public List<Composite> Parti
        {
            get { return _parti; }
            set { _parti = value; }
        }

        public Aliante() 
        {
            Parti = new List<Composite>();
        }

        public Aliante(List<Composite> parti)
        {
            Parti = parti;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Aliante) || obj == null)
            {
                return false;
            }

            Aliante other = (Aliante)obj;
            if (Parti.Count != other.Parti.Count)
            {
                return false;
            }

            for (int i = 0; i < Parti.Count; i++)
            {
                if (!Parti[i].Equals(other.Parti[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public override void Add(Composite componente)
        {
            Parti.Add(componente);
        }

        public override void Remove(Composite componente)
        {
            Parti.Remove(componente);
        }

        public override Composite GetChild(int index)
        {
            return base.GetChild(index);
        }

        public override string ToString()
        {
            string str = "";

            foreach (var component in Parti)
            {
                str += component.ToString();
            }

            return str;
        }

        public override double Price()
        {
            double PrTot = 0;

            foreach (var component in Parti)
            {
                PrTot += component.Price();
            }

            return PrTot;
        }
    }
}
