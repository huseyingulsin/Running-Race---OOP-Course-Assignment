using System;
using System.Collections;
using System.IO;
namespace Yarisma
{
    public class Yarisma
    {
        private string yarismacilarr;
        private uint yarismaPisti;
        bool x = true;
        public string Yarismacilarr { get; set; }
        public  void  Baslat()
        {

            Random av = new Random();
            int avci = av.Next(0, 11);

            while (x == true)
            {


                for (int i = 0; i < yarismacilar.Count(); i++)
                {
                    var a = yarismacilar.ElementAt(i);
                    a.HareketEt();
                    if (a.Konum >= yarismaPisti)
                    {
                        a.Konum = Convert.ToInt32(yarismaPisti);
                        x = false;
                        break;
                    }
                    for (int j = 0; j < yarismacilar.Count(); j++)
                    {
                        var b = yarismacilar.ElementAt(j);
                        if (i != j)
                        {

                            if (a.Tur == "CAKAL" && b.Tur == "DEVEKUSU" && a.Konum == b.Konum)
                            {
                                if (avci > 0 && avci <= 5)
                                {

                                }

                            }



                        }
                    }


                }




            }

        }
        string[] kelimeler;

        List<IYarismaci> yarismacilar = new List<IYarismaci>();

        public Yarisma(string yarismaciDosyasiYolu, uint pistUzunlugu)
        {

            yarismaPisti = pistUzunlugu;



            string dosya = yarismaciDosyasiYolu;

            FileStream bir = new FileStream(dosya, FileMode.Open, FileAccess.Read);

      
            StreamReader iki = new StreamReader(bir);
           
                

            

           
            while (!iki.EndOfStream)
            {
                string satir = iki.ReadLine();
                string[] kelimeler = satir.Split(' ');
                switch (kelimeler[2])
                {
                    case "CAKAL":
                        Cakal c = new Cakal(kelimeler[1], Int32.Parse(kelimeler[0]));
                        yarismacilar.Add(c);
                        
                        break;
                    case "DEVEKUSU":
                        Devekusu dk = new Devekusu(kelimeler[1], Int32.Parse(kelimeler[0]));
                        yarismacilar.Add(dk);
                        
                        break;
                    case "MEKANIKFIL":
                        MekanikFil mf = new MekanikFil(kelimeler[1], Int32.Parse(kelimeler[0]));
                        yarismacilar.Add(mf);
                      
                        break;
                    case "SALYANBOT":
                        SalyanBot sb = new SalyanBot(kelimeler[1], Int32.Parse(kelimeler[0]));
                        yarismacilar.Add(sb);
                      
                        break;

                    default:
                        break;
                }
            }

           

           
             
        


         


            





            iki.Close();
            bir.Close();

           

         
        }
        public int KonumlariYazdir()
        {



            foreach (var i in yarismacilar)
            {


                Console.WriteLine(i.Konum + " :: " + i.Isim + "," + i.YarismaciNo);



            }








            return 0;
        }

    }
}