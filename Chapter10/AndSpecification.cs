using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Chapter10
{
    public class AndSpecification : AbstractSpecification
    {
        Specification one;
        Specification other;

        public AndSpecification(Specification x, Specification y)
        {
            one = x;
            other = y;
        }
        public override bool isSatisfiedBy(object candidate)
        {
            return one.isSatisfiedBy(candidate) && other.isSatisfiedBy(candidate);
        }
    }
}
