using System;

namespace Yarisma
{
    class Devekusu : Hayvan
    {
        public int Paralize { get; set; }
        public override string Isim { get; set; }
        public override int YarismaciNo { get; set; }
        public override string Tur { get; set; }

        public Devekusu(string isim,int no)
        {

            this.Konum = 0;
            this.Isim = isim;
            this.YarismaciNo = no;
            this.Tur = "DEVEKUSU";

        }
        public override void HareketEt()
        {
            
            Random rastgele = new Random();
            double rng = rastgele.Next(0, 11);
  
                
                if (rng >= 1 && rng <= 5)
                {
                // koşma eylemi
                Konum = Konum + 3;


                }
                if (rng > 5 && rng <=7)
                {
                // hızlı koşma eylemi
                Konum = Konum + 6;
                }
                if (rng > 7 && rng <=10)
                {
                // kayma eylemi
                Konum = Konum - 4;
                }
            
            
                
        }

      
    }

}