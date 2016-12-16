using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Chapter10
{
    public interface Specification
    {
        bool isSatisfiedBy(object candidate);

        Specification and(Specification other);
        Specification or(Specification other);
        Specification not();
    }
}
