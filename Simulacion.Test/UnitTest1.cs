using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Simulacion.Test
{
    [TestClass]
    public class SimulacionTest
    {
        Simulacion Simulacion{get;set;}
        [TestMethod]
        public void SimulacionConTask()
        {
            var Bolillero = new Bolillero.Core.Bolillero(10);

            Simulacion = new Simulacion();

            var jugada = new List<byte>{5};

            long cantidadVeces = 10000000;

            double esperado = cantidadVeces/10.0;

            var ganadasSinHilos = Simulacion.SimularSinHilos(Bolillero, cantidadVeces, jugada);

            var ganadasConHilos = Simulacion.SimularConHilos(Bolillero , cantidadVeces , jugada ,8);

            assert.AreEqual(ganadasConHilos/esperado, ganadasSinHilos/esperado,0.1);

        }
    }
}
