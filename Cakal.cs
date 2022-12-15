using System;

namespace Yarisma
{
    class Cakal : Hayvan
    {
        public string cesit;
        
        public override int YarismaciNo { get; set; }
        public override string Isim { get; set; }
        public override string Tur { get; set; }

        public Cakal(string adi, int yarismaciNo)
        {
            this.Konum = 0;
            this.Isim = adi;
            this.YarismaciNo = yarismaciNo;
            this.Tur = "CAKAL";


        }
        public override void HareketEt()
        {
            
            Random rastgele = new Random();
            rng = rastgele.Next(0, 11);
            
            
                if (rng >= 1 && rng <= 3)
                {
                    // koşma eylemi
                    Konum = Konum + 3;
                    


                }
                if (rng > 3 && rng <= 8)
                {
                    // yürüme eylemi
                    Konum = Konum + 2;

                }
                if (rng > 8 && rng <= 10)
                {
                    // kayma eylemi
                    Konum = Konum - 4;

                }
            

        }

        
    }
}