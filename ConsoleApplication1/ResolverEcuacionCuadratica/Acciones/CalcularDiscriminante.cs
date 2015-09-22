using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolverEcuacionCuadratica
{
    public class CalcularDiscriminante
    {
        public double CalcularElDiscriminante(EspecificarVariables variables)
        {
            double resultado = 0;
            resultado = (Math.Pow(variables.getSegundoNumero(), 2) - 4 * variables.getPrimerNumero() * variables.getTercerNumero());
            return (resultado);
        }
    }
}
