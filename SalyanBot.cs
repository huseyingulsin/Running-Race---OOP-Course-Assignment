using System;

namespace Yarisma
{
    class SalyanBot : Robot
    {
      
        public int salyanbotkonum;

        protected override string bozuldu { get; set; }
        public override string Isim { get; set; }
        public override int Konum { get; set; }
        public override int YarismaciNo { get; set; }
        public override string Tur { get; set; }

        public SalyanBot(string isim, int no)
        {
            this.Konum = 0;
            this.Isim = isim;
            this.YarismaciNo = no;
            this.Tur = "SALYANBOT";
        }
        public override void HareketEt()
        {
            Random rastgele = new Random();
            rng = rastgele.Next(0, 10);

            if (rng >= 1 && rng <= 10)
            {
                Konum = Konum + 1;
                // sürünme eylemi
            }
            
        }

        

       

        
    }
}