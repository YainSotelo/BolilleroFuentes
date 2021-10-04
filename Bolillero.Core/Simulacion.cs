using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Bolillero.Core
{
    public class Simulacion 
    {
        public long SimularSinHilos(Bolillero Bolillero, long JogoBonitoNveces, List<byte> JogoBonito)
        {
            return Bolillero.JogoBonitoNveces(JogoBonito , JogoBonitoNveces);
        }

        public long SimularConHilos(Bolillero bolillero, long JogoBonitoNveces, List<byte> JogoBonito ,int cantidadHilos)
        {
            var vector = new Task<long>[cantidadHilos];

            long SimulacionPorHilos = JogoBonitoNveces/cantidadHilos;
            
            for (int i=0; i < cantidadHilos; i++)
            {
                var clone = (Bolillero)bolillero.Clone();

                vector[i] = Task<long>.Run(() => clone.JogoBonitoNveces(JogoBonito , SimulacionPorHilos));

            }
            Task<long>.WaitAll(vector);

            return vector.Sum(t => t.Result); 

        }
        public async Task<long> SimularConHilosAsync(Bolillero bolillero, long JogoBonitoNveces, List<byte> JogoBonito ,int cantidadHilos)
        {
            var vector = new Task<long>[cantidadHilos];

            long SimulacionPorHilos = JogoBonitoNveces/cantidadHilos;
            
            for (int i=0; i < cantidadHilos; i++)
            {
                var clone = (Bolillero)bolillero.Clone();

                vector[i] = Task<long>.Run(() => clone.JogoBonitoNveces(JogoBonito , SimulacionPorHilos));

            }
            await Task.WhenAll(vector);

            return vector.Sum(t => t.Result); 
        }
        
    }
}