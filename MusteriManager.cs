using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " " + "Eklendi.");
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " " + "Silindi.");
        }

        public void Update(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " " + "Güncellendi");
        }

        public void List(Musteri[] musteriler)
        {
            for (int i = 0; i < musteriler.Length; i++)
            {
                Console.WriteLine("Ad Soyad:" + musteriler[i].Name + " " + musteriler[i].Surname + "Tc :" + musteriler[i].Tc + " Job: " + musteriler[i].Job);
            }
        }
    }
}
