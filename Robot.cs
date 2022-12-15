using System;

namespace Yarisma
{   
    abstract class Robot : IYarismaci
    {

        protected int rng;
        
        private int yarismaciNo;
        protected int yarismaPisti;
        

        private string isim;
            

        //istenilen properties

        protected abstract string bozuldu { get; set; }
        public abstract string Isim { get; set; }
        public abstract int Konum { get; set; }
        public abstract int YarismaciNo { get; set; }
        public abstract string Tur { get; set; }
        public bool Paralize {get; set; }

        public abstract void HareketEt();
        public void Hayvan()
        {

        }

        
    }
}