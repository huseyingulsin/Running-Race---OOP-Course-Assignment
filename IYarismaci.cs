using System;

namespace Yarisma
{
    interface IYarismaci
    {

        public string Isim  // property
        { get; set; }
        public int Konum { get; set; }
        public int YarismaciNo { get; set; }

        public string Tur { get; set; }

        public bool Paralize { get; set; }
        void HareketEt();
       
    }
}