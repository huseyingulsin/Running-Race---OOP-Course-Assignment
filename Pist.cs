using System;
using System.IO;

namespace Yarisma
{
    class Pist
    {
        private int pist;
        
      
        public int PistUzunlugu { get; set; }

        

        public void DurumuYazdir()
        {
            //bu metodlarla ilgili yapılacak işlemlerin detayı ödevde belirtilmediği için sadece oluşturdum


        }
        public static void KonumdakiYarisci()
        {
            //bu metodlarla ilgili yapılacak işlemlerin detayı ödevde belirtilmediği için sadece oluşturdum


        }
        public static void KonumGuncelle()
        {
            //bu metodlarla ilgili yapılacak işlemlerin detayı ödevde belirtilmediği için sadece oluşturdum


        }
        public Pist()
        {
            

        }

        public static void YarismaciEkle(string yarismaciDosyasiYolu, uint pistUzunlugu)
        {
           

            FileStream stream = File.Create(yarismaciDosyasiYolu);
            StreamWriter sw = new StreamWriter(stream);
            //eklenmek istenen yarışmacıyı aşağıdaki kısma yazabilirsiniz hocam
            // sw.WriteLine("Tek satır metin.");
          
            sw.Close();
        }


    }
}