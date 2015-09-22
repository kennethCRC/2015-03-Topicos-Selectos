using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolverEcuacionCuadratica
{
    public class CalcularRaices
    {
        public void CalcularLasRaices(EspecificarVariables variables)
        {
            variables.setPrimeraRaiz ((-variables.getSegundoNumero() + Math.Sqrt(variables.getDiscriminante())) / (2 * variables.getPrimerNumero()));
            variables. setSegundaRaiz ((-variables.getSegundoNumero() - Math.Sqrt(variables.getDiscriminante())) / (2 * variables.getPrimerNumero()));
        }
    }
}
