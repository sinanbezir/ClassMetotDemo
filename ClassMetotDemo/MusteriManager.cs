using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " " + musteri.Surname + " isimli müşteri eklendi");
        }

        public void Listele(Musteri[] musteri)
        {
            foreach (Musteri m in musteri)
            Console.WriteLine(m.Name + " " + m.Surname );
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " " + musteri.Surname + " isimli müşteri silindi");
        }

    }
}
