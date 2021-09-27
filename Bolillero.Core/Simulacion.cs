using System;
using System.Linq;
using System.Therading.Tasks;
using System.Collections.Generic;

namespace Bolillero.Core
{
    public class Simulacion 
    {
        public long SimularSinHilos(Bolillero Bolillero, long JogoBonitoNveces, List<byte> JogoBonito)
        {
            return Bolillero.JogoBonitoNveces(JogoBonito , JogoBonitoNveces);
        }

        public long SimularConHilos(Bolillero Bolillero, long JogoBonitoNveces, List<byte> JogoBonito ,int cantidadHilos)
        {
            var vector = new Task<long>[cantidadHilos];

            long SimularPorHilos = JogoBonitoNveces/cantidadHilos;
            
            for (int i=0; i < cantidadHilos; i++)
            {
                var clone = (Bolillero)Bolillero.clone();

                vector[i] = Task<long>.Run(() => clone.JogoBonitoNveces(JogoBonito , SimularPorHilos));

            }
            Task<long>.WaitAll(vector);

        return vector.Sum(t => t.Result); 
           
        }
    
    }
}