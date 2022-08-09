using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismOrnek
{
    public class Sekil //base class
    {
        public string isim { get; set; }
        public Sekil(string isim)
        {
            this.isim = isim;
        }

        public string getIsim()
        {
            return isim;
        }

        public virtual void sekilHesapla()
        {
            Console.WriteLine("Şeklin alanı hesaplanıyor..");
        }

        public virtual void sekilBilgileriGoster()
        {
            Console.WriteLine(getIsim() + " nin bilgileri !");
        }

    }
}
