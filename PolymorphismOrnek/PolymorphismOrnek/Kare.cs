using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismOrnek
{
    public class Kare : Sekil
    {
        public int kenar { get; set; }
        public Kare(string isim, int kenar) : base(isim)
        {
            this.kenar = kenar;
        }
        public override void sekilHesapla()
        {
            base.sekilHesapla();
            Console.WriteLine(getIsim() + " nin alanı : " + (kenar * kenar));
        }
        public override void sekilBilgileriGoster()
        {
            base.sekilBilgileriGoster();
            Console.WriteLine("Şeklin ismi : " + getIsim());
            Console.WriteLine(getIsim() + " nin kenar uzunluğu : " + this.kenar);
        }
    }
}
