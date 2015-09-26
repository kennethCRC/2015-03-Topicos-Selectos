using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolverEcuacionCuadratica
{
    public class ResolverEcuacionCuadratica
    {
        public void ResolverLaEcuacionCuadratica(EspecificarVariables variables)
        {
            //calcular el discriminante
            CalcularDiscriminante accCalcularDiscriminante = new CalcularDiscriminante();
            variables.setDiscriminante (accCalcularDiscriminante.CalcularElDiscriminante(variables));
            //validar el discriminante
            ValidarDiscriminante validarDiscriminante = new ValidarDiscriminante();
            if (validarDiscriminante.ValidarElDiscriminanteMayorQueCero(variables))
            {

                //calcular las raices
                CalcularRaices calcularRaices = new CalcularRaices();
                calcularRaices.CalcularLasRaices(variables);
            }
            else
            //levante una excepción
            {
                Exception ex = new Exception(string.Format("Ocurrió un error al calcular las raices," + 
                            " ya que el discriminante [{0}] es menor que cero", variables.getDiscriminante().ToString()));
                throw ex;
            }
        }
    }
}
