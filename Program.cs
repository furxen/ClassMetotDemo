using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();

            Musteri musteri1 = new Musteri();
            musteri1.Tc = 12345678910;
            musteri1.Name = "Furkan";
            musteri1.Surname = "Kayacı";
            musteri1.Job = "Öğrenci";

            Musteri musteri2 = new Musteri();
            musteri2.Tc = 12345678911;
            musteri2.Name = "Hüseyin";
            musteri2.Surname = "Çavlı";
            musteri2.Job = "Kasap";
            
            Musteri musteri3 = new Musteri();
            musteri3.Tc = 12345678912;
            musteri3.Name = "Ökkeş";
            musteri3.Surname = "Kurt";
            musteri3.Job = "Muhasebeci";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            musteriManager.List(musteriler);
        }
    }
}
