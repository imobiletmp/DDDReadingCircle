using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Chapter10
{
    public class NotSpecification : AbstractSpecification
    {
        Specification wrapped;

        public NotSpecification(Specification x)
        {
            wrapped = x;
        }
        public override bool isSatisfiedBy(object candidate)
        {
            return !wrapped.isSatisfiedBy(candidate);
        }
    }
}
