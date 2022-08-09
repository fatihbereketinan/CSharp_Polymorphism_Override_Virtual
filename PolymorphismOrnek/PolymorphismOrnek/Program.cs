using System;

namespace PolymorphismOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = true;
            Console.WriteLine("Şekil uygulamsına hoşgeldiniz ! ");
            Console.WriteLine("");
            while (kontrol)
            {
                Console.WriteLine("1- Dikdörtgen işlemleri");
                Console.WriteLine("2- Üçgen işlemleri");
                Console.WriteLine("3- Kare işlemleri");
                Console.WriteLine("q- Çıkış Yap");
                Console.Write("Lütfen bir işlemi seçiniz: ");
                string islem = Console.ReadLine();

                switch (islem)
                {
                    case "q":
                        kontrol = false;
                        break;

                    case "1":
                        while (true)
                        {
                            Console.WriteLine("1- Dikdörtgen Alan Hesapla");
                            Console.WriteLine("2- Dikdörtgen Bilgileri Göster");
                            Console.WriteLine("q- Çıkış Yap");
                            Console.Write("Lütfen bir işlemi seçininiz: ");
                            string secimDikdortgen = Console.ReadLine();
                            if (secimDikdortgen == "1")
                            {
                                Console.Write("Kısa kenarı giriniz: ");
                                int kısakenar = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Uzun kenarı giriniz: ");
                                int uzunkenar = Convert.ToInt32(Console.ReadLine());
                                Dikdortgen dikdortgen = new Dikdortgen("Dikdörtgen", kısakenar, uzunkenar);
                                dikdortgen.sekilHesapla();
                            }
                            else if (secimDikdortgen == "2")
                            {
                                Console.Write("Kısa kenarı giriniz: ");
                                int kısakenar = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Uzun kenarı giriniz: ");
                                int uzunkenar = Convert.ToInt32(Console.ReadLine());
                                Dikdortgen dikdortgen = new Dikdortgen("Dikdörtgen", kısakenar, uzunkenar);
                                dikdortgen.sekilBilgileriGoster();
                            }
                            else if (secimDikdortgen == "q")
                            {
                                Console.WriteLine("Dikdörtgen işlemlerinden çıkılıyor..");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Hatalı işlem yaptınız!!!");
                                Console.WriteLine("");
                            }
                        }
                        break;

                    case "2":
                        while (true)
                        {

                            Console.WriteLine("1- Üçgen Alan Hesapla");
                            Console.WriteLine("2- Üçgen Bilgileri Göster");
                            Console.WriteLine("q- Çıkış Yap");
                            Console.Write("Lütfen bir işlemi seçininiz: ");
                            string secimUcgen = Console.ReadLine();
                            if (secimUcgen == "1")
                            {
                                Console.Write("Taban alanını giriniz: ");
                                int tabanalani = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Yüksekliği giriniz: ");
                                int yukseklik = Convert.ToInt32(Console.ReadLine());
                                Ucgen ucgen = new Ucgen("Üçgen", tabanalani, yukseklik);
                                ucgen.sekilHesapla();
                            }
                            else if (secimUcgen == "2")
                            {
                                Console.Write("Taban alanını giriniz: ");
                                int tabanalani = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Yüksekliği giriniz: ");
                                int yukseklik = Convert.ToInt32(Console.ReadLine());
                                Ucgen ucgen = new Ucgen("Üçgen", tabanalani, yukseklik);
                                ucgen.sekilBilgileriGoster();
                            }
                            else if (secimUcgen == "q")
                            {
                                Console.WriteLine("Üçgen işlemlerinden çıkılıyor..");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Hatalı işlem yaptınız!!!");
                                Console.WriteLine("");
                            }
                        }
                        break;
                    case "3":
                        while (true)
                        {

                            Console.WriteLine("1- Kare Alan Hesapla");
                            Console.WriteLine("2- Kare Bilgileri Göster");
                            Console.WriteLine("q- Çıkış Yap");
                            Console.Write("Lütfen bir işlemi seçininiz: ");
                            string secimKare = Console.ReadLine();
                            if (secimKare == "1")
                            {
                                Console.Write("Kenar uzunluğunu giriniz: ");
                                int kenar = Convert.ToInt32(Console.ReadLine());
                                Kare kare = new Kare("Kare", kenar);
                                kare.sekilHesapla();
                            }
                            else if (secimKare == "2")
                            {
                                Console.Write("Kenar uzunluğunu giriniz: ");
                                int kenar = Convert.ToInt32(Console.ReadLine());
                                Kare kare = new Kare("Kare", kenar);
                                kare.sekilBilgileriGoster();
                            }
                            else if (secimKare == "q")
                            {
                                Console.WriteLine("Kare işlemlerinden çıkılıyor..");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Hatalı işlem yaptınız!!!");
                                Console.WriteLine("");
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Hatalı işlem yaptınız !!!");
                        break;
                }
            }
            Console.WriteLine("Uygulamadan çıkış yapılmıştır..");
        }
    }
}
