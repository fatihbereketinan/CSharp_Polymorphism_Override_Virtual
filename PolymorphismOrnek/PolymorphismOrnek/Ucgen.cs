using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismOrnek
{
    public class Ucgen : Sekil
    {
        public int tabanAlani { get; set; }
        public int yukseklik { get; set; }

        public Ucgen(string isim, int tabanAlani, int yukseklik) : base(isim)
        {
            this.tabanAlani = tabanAlani;
            this.yukseklik = yukseklik;
        }
        public override void sekilHesapla()
        {
            base.sekilHesapla();
            Console.WriteLine(getIsim()+" nin alanı : "+((tabanAlani*yukseklik)/2));
        }
        public override void sekilBilgileriGoster()
        {
            base.sekilBilgileriGoster();
            Console.WriteLine("Şeklin ismi : " + getIsim());
            Console.WriteLine(getIsim() + " nin taban alanı : " + this.tabanAlani);
            Console.WriteLine(getIsim() + " nin yüksekliği : " + this.yukseklik);
        }
    }
}
