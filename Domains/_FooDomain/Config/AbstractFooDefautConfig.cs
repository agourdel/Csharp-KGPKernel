using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGPKernel.Domains._FooDomain.Config
{
    public abstract class AbstractFooDefautConfig
    {
        public virtual int FirstValue { get; protected set; } = 42;
        public virtual String SecondValue { get; protected set; } = "Defaut";

        protected AbstractFooDefautConfig()
        {
        }
    }
}
