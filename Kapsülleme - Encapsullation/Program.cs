using System;

namespace Kapsülleme___Encapsullation
{
        /* 
         * Kapsülleme ve Encapsullation
         * Kapsülleme ve Encapsullation
         * Girilen verinin sıkıştırılması ve açılmasıdır
         * Veri girişinde kontrol edilir sonrasında bu göre set edilir
         * Veri get edilirken kontrol edilir ona göre sonuç verilir
         * hazir kod blogu için prob ve probfull kullanılır
         * Yapılacaklar
         * Firma ürün fiyatları için bir program oluşturalım
         * Aynı zamanda oluşturulurken kalıtım kullanalım
         * 
        */
     class Program
    {
        static void Main(string[] args)
        {
            ÜrünBilgisi ürünBilgisi=new ÜrünBilgisi();
            ürünBilgisi.UrunAdi = "Ram";
            ürünBilgisi.UrunFiyat = 400;
            ürünBilgisi.UrunAdet = 20;
        }
    }
  
}
