using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bolillero.Core;
using System.Collections.Generic;

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

          Assert.AreEqual(1, Bolillero.afuera.Count);

          Assert.AreEqual(9,Bolillero.adentro.Count); 
        }

        [TestMethod]
        public void Probable()
        {
           Bolillero = new Bolillero.Core.Bolillero(5);

           var jugadaFacil = new List<byte>(){2};

           var ganadas =  Bolillero.JogoBonitoNveces(jugadaFacil , 100);

           Assert.AreEqual(0.2 , ganadas/100, 0.5 );





        }


    }
}
