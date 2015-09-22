using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolverEcuacionCuadratica
{
     public class ValidarDiscriminante
    {
        public bool ValidarElDiscriminanteMayorQueCero (EspecificarVariables variables)
        {
            bool resultado = false;
            resultado = (variables.getDiscriminante() >= 0);
            return resultado;
        }
    }
}
