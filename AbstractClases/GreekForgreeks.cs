using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.AbstractClases
{
    public abstract class GreekForgreeks: ICloneable
    {
        /*
         * las clase abstractas me permite crear metodos y interfaces abtractas
         * USAR LAS DOS
         }*/
        public abstract void gfg();
        public abstract object Clone() ;
        public string Test()
        {
            return "we are testing";
        }
        public virtual string VirtualMethod() //m etodo sobreescribirle, que indica que es una version del metodo 
        {
           return "we are virtual method";
        }

    }
}
