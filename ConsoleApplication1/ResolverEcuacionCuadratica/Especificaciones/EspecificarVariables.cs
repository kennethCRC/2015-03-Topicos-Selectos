using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolverEcuacionCuadratica
{
    public class EspecificarVariables
    {
       
            double primerNumero = 0;
            double segundoNumero = 0;
            double tercerNumero = 0;
            double discriminante = 0;
            double primeraRaiz = 0;
            double segundaRaiz = 0;

        public void setPrimerNumero (double num)
        {
            primerNumero = num;
        }
        public double getPrimerNumero ()
        {
            return primerNumero;
        }
        public void setSegundoNumero (double num)
        {
            segundoNumero = num;
        }
        public double getSegundoNumero ()
        {
            return segundoNumero;
        }
        public void setTercerNumero (double num)
        {
            tercerNumero = num;
        }
        public double getTercerNumero()
        {
            return tercerNumero;
        }
        public void setDiscriminante (double dis)
        {
            discriminante = dis;
        }
        public double getDiscriminante ()
        {
            return discriminante;
        }
        public void setPrimeraRaiz (double pr)
        {
            primeraRaiz = pr;
        }
        public double getPrimeraRaiz ()
        {
            return primeraRaiz;
        }
        public void setSegundaRaiz (double sr)
        {
            segundaRaiz = sr;
        }
        public double getSegundaRaiz ()
        {
            return segundaRaiz;
        }
    }
}
