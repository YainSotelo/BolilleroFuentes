using System;
using System.Collections.Generic;
using System.Text;

namespace Bolillero.Core
{
    public class Bolillero
    {
         byte cantidad {get; set;}

        byte BolitasAzar{get; set;}
           
        List<byte>  afuera {get; set;}

        List<byte> adentro {get; set;}

        Random r;

        public Bolillero()
        {
            afuera = new List<byte>();
            adentro = new List<byte>();
             r = new Random();

        }
       
       public Bolillero(byte cantidad):this()
       {
           this.llenar(cantidad);
       }

       private void llenar (buty cantidad)
       {
           for (int i = 0; i < cantidad; i++)
           {
               adentro.add(i);
           }
       }

       public byte sacarBolilla()
       {
           byte aleatorio = (byte)r.next(0,adentro.count);

           byte bolilla= adentro [aleatorio];

           adentro.removeAt(aleatorio);

           afuera.add(bolilla);

           return bolilla;
       }

       public void RecargarBolillero()
       {
           adentro.addRanger(afuera);

           afuera.clear();
       }

        public bool JogoBonito(List<byte> Toque)
       {
           RecargarBolillero();
           for (int i = 0; i < Toque; i++)
           {

           }
                    
       }

       public bool JogoBonitoNveces();
       {
           
       }
       


    }

    
