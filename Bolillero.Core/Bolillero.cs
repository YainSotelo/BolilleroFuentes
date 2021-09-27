using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bolillero.Core
{
    public class Bolillero : ICloneable
    {
         byte cantidad {get; set;}

        byte BolitasAzar{get; set;}
           
        public List<byte>  afuera {get; set;}

        public  List<byte> adentro {get; set;} 

        Random r;

        public Bolillero()
        {
            afuera = new List<byte>();
            adentro = new List<byte>();
            r = new Random(DateTime.Now.Milisecond);

        }
       
       public Bolillero(byte cantidad):this()
       {
        this.llenar(cantidad);
       }

        public Bolillero(Bolillero original)
        {
            afuera = new List<byte>(original.afuera);
            adentro = new List<byte>(original.adentro);
            r = new Random(DateTime.Now.Milisecond);

        }

       private void llenar (byte cantidad)
       {
           for (byte i = 0; i < cantidad; i++)
           {
               adentro.Add(i);
           }
       }

       public byte sacarBolilla()
       {
           byte aleatorio = (byte)r.Next(0,adentro.Count);

           byte bolilla= adentro [aleatorio];

           adentro.RemoveAt(aleatorio);

           afuera.Add(bolilla);

           return bolilla;
       }

       public void RecargarBolillero()
       {
           adentro.AddRange(afuera);

           afuera.Clear();
       }

        public bool JogoBonito(List<byte> Toque)
       {
           RecargarBolillero();
           for (byte i = 0; i < Toque.Count; i++)
           {
               if( sacarBolilla () !=Toque[i])
               {
                   return false;
               }

           
           } 
           return true;        
       }
        

       public long JogoBonitoNveces( List<byte> Toque,long cantidad )
        { 
         long contador = 0;

         for (byte i = 0; i < cantidad; i++)
         {
             if (JogoBonito(Toque))
             {
                contador++;
             }
             
         }
         return contador;
           
        }
           public objeto clon(){

             return new Bolillero(this);
           }
       
    }}

    
