using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismOrnek
{
    public class Dikdortgen : Sekil
    {
        public int kisaKenar { get; set; }
        public int uzunKenar { get; set; }
        public Dikdortgen(string isim, int kısaKenar, int uzunKenar) : base(isim)
        {
            this.kisaKenar = kısaKenar;
            this.uzunKenar = uzunKenar;
        }
        public override void sekilHesapla()
        {
            base.sekilHesapla();
            Console.WriteLine(getIsim()+ " nin alanı : "+(kisaKenar*uzunKenar));
        }
        public override void sekilBilgileriGoster()
        {
            base.sekilBilgileriGoster();
            Console.WriteLine("Şeklin ismi : "+getIsim());
            Console.WriteLine(getIsim()+" nin kısa kenarı : "+this.kisaKenar);
            Console.WriteLine(getIsim()+" nin uzun kenarı : "+this.uzunKenar);
        }
    }
}
