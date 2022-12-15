using System;

namespace Yarisma
{
    abstract class Hayvan : IYarismaci
    {
        //istenilen field'lar
        protected int rng;
        private int yarismaciNo;
       
        protected int yarismaPisti;
      

      ///istenilen property'ler
        public abstract string Isim { get; set; }
        
        public  int Konum { get; set; } 
   
        public abstract int YarismaciNo { get; set; }

        public abstract string Tur { get; set; }
        public bool Paralize { get; set; }

        public abstract void HareketEt();

       

        public Hayvan()
        {

        }
    }
}