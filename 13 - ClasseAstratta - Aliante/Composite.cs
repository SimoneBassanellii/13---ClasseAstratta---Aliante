using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___OGGETTI_UML___Aliante
{
    public abstract class Composite
    {
        public virtual void Add(Composite componente)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Composite componente)
        {
            throw new NotImplementedException();
        }

        public virtual Composite GetChild(int index)
        {
            throw new NotImplementedException();
        }

        public new abstract bool Equals(object obj);

        public new abstract string ToString();

        public abstract double Price();
    }
}
