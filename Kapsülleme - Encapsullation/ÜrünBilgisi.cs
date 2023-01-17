using System;
using System.Collections.Generic;
using System.Text;

namespace Kapsülleme___Encapsullation
{
    class ÜrünBilgisi
    {
        private string urunAdi;
        public string UrunAdi
        {
            get { return urunAdi; }
            set
            {
                if (check(value, "Ürün Adını Boş Geçemessiniz!"))
                {
                    urunAdi = value;
                }
            }
        }

        private int urunFiyat;
        public int UrunFiyat
        {
            get { return urunFiyat; }
            set
            {
                if (check(value, "Ürün Fiyatı Sıfırdan Büyük Olmalı!"))
                {
                    urunFiyat = value;
                }
            }
        }
        private int urunAdet;

        public int UrunAdet
        {
            get { return urunAdet; }
            set
            {
                if (check(value, "Ürün Adeti Sıfırdan Büyük Olmalı!"))
                {
                    urunFiyat = value;
                }
            }
        }
        private bool check(object checkObject, string msj)
        {
            if (checkObject.GetType() == typeof(int))
            {
                if ((int)checkObject <= 0)
                {
                    Console.WriteLine(msj);
                    return false;
                }
                else
                {
                    return true;
                }

            }
            if (checkObject.GetType() == typeof(string))
            {
                if (string.IsNullOrEmpty((string)checkObject))
                {
                    Console.WriteLine(msj);
                    return false;
                }
                else
                {
                    return true;
                }

            }
            return false;
        }

    }
}
