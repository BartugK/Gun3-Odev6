using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void MusteriEkleme(Musteri customer)
        {
            Console.WriteLine("Sisteme " +customer.MusteriIsmi+ " isimli, " + customer.MusteriId  +" Tc kimlik numaralı müşteri başarılı bir şekilde eklenmiştir.");
        }

        public void MusteriSilme(Musteri customer)
        {
            Console.WriteLine("Sistemden " + customer.MusteriIsmi + " isimli, " + customer.MusteriId + " Tc kimlik numaralı müşteri başarılı bir şekilde silinmiştir.");
        }

        public void MusteriListeleme(Musteri customer)
        {
            Console.WriteLine("Müşterinin ismi : " +customer.MusteriIsmi+ " ,Müşterinin Tc kimlk numarası : " + customer.MusteriId+ " ,Müşterinin Yaşı : " + customer.MusteriYasi);
        }





    }
}
