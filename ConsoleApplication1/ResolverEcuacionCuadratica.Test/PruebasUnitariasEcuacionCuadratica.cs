using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResolverEcuacionCuadratica;


namespace ResolverEcuacionCuadratica.Test
{
    [TestClass]
    public class PruebasUnitariasEcuacionCuadratica
    {
        [TestMethod]
        public void ProbarResolverCorrectoMuyMuyExacto()
        {
            //declarar variables para los resultados esperados
            //declarar variables para los resultados reales
            //construir la lógica que realiza la prueba
            //Asegurar que los valores reales son iguales que los esperados
            double primerNumero = -1;
            double segundoNumero = 2;
            double tercerNumero = 3;
            double primeraRaizReal = 0;
            double segundaRaizReal = 0;
            double esperadoPrimerRaiz = 3;
            double esperadoSegundaRaiz = -1;

            EspecificarVariables variables = new EspecificarVariables();
            variables.setPrimerNumero(primerNumero);
            variables.setSegundoNumero(segundoNumero);
            variables.setTercerNumero(tercerNumero);
            ResolverEcuacionCuadratica ecuacionCuadratica = new ResolverEcuacionCuadratica();
            //invocar el metodo correspondiente para resolver la ecuación
            ecuacionCuadratica.ResolverLaEcuacionCuadratica (variables);
            primeraRaizReal = variables.getPrimeraRaiz();
            segundaRaizReal = variables.getSegundaRaiz();

            Assert.IsTrue((esperadoPrimerRaiz == primeraRaizReal) ||
                           (esperadoPrimerRaiz == segundaRaizReal));

            Assert.IsTrue((esperadoSegundaRaiz == segundaRaizReal) ||
                          (esperadoSegundaRaiz == primeraRaizReal));
            /*
            Tarea moral: hecferme
            cree pruebas unitarias para los siguientes casos:
            - Pruebas correctas para resultados reales con muchos decimales, de modo que la coincidencia
            no sea muy muy exacto y se aprueben cuando coincidan  al menos en el sexto decimal.
            - Pruebas correctas para cuando el discriminante es negativo
            - Pruebas para cuando el valor de A (primer número) es igual a cero(0).
            */
        }
    }
}
