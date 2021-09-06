using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bolillero.Core;

namespace Bolillero.Test
{
    [TestClass]
    public class BolilleroTest
    {
        Bolillero.Core.Bolillero Bolillero {get;set;}
        [TestMethod]
        public void Bolillas()
        {
          Bolillero  = new Bolillero.Core.Bolillero(10); 

          Bolillero.sacarBolilla();

          Assert.AreEqual(1, Bolillero.afuera);

          Assert.AreEqual(9,Bolillero.adentro); 
        }

        public void Probable()
        {
           Bolillero = new Bolillero.Core.Bolillero(5);

           var jugadaFacil = new List<byte>()[2];

           var ganadas =  Bolillero.JogoBonitoNveces(jugadaFacil , 100);

           assert.AreEqual(0.2 , ganadas/100, 0.5 );





        }


    }
}
