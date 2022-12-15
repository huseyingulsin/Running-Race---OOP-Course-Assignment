using System;

namespace Yarisma
{
    class MekanikFil : Robot
    {






        protected override string bozuldu { get; set; }
        public override string Isim { get; set; }
        public override int Konum { get; set; }
        public override int YarismaciNo { get; set; }
        public override string Tur { get; set; }

        public MekanikFil(string adi, int yarismaciNo)
        {
            this.Konum = 0;
            this.Isim = adi;
            this.YarismaciNo = yarismaciNo;
            this.Tur = "MEKANIKFIL";


        }
    
        public override void HareketEt()
        {
            Random rastgele = new Random();
             rng = rastgele.Next(0, 11);

               
                if (rng >= 1 && rng <= 4)
                {
                    // yürüme eylemi
                    Konum = Konum + 2;

                }
                if (rng > 4 && rng <= 5)
                {
                    // koşma eylemi
                    Konum = Konum + 3;
                }
                if (rng > 5 && rng <= 10)
                {
                    // bekleme eylemi
                    
                }
                
            
          

        }
      
    }
}