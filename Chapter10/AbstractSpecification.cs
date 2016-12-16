using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Chapter10
{
    public abstract class AbstractSpecification : Specification
    {
        public Specification and(Specification other)
        {
            return new AndSpecification(this, other);
        }

        public Specification or(Specification other)
        {
            return new OrSpecification(this, other);
        }

        public Specification not()
        {
            return new NotSpecification(this);
        }

        public abstract bool isSatisfiedBy(object candidate);
    }
}
