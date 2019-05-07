using SmartHomeV4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeV4.Service
{
    public interface IKullaniciService
    {
        int GirisKontrol(string kullaniciAdi, string password);
        string GirisKontrol2(string kullaniciAdi, string password);
        kullanici GirisKontrol3(string kullaniciAdi, string password);

        List<kullanici> GetKullanici();



        bool SaveKullanici(kullanici kullanici);

        bool Delete(string kullaniciAdi);
        bool Delete2(string kullaniciAdi);

        bool updateKullanici(kullanici kull);

        kullanici getKullanici2(string kullaniciAdi);

        evDurumu getHome(int HomeId);

        bool updateHome(evDurumu evDurumu);

        evDurumu openClose(evDurumu evDurumu); //ledin veri tabanındaki değerini değiştrime
        evDurumu openCloseGas(evDurumu evDurumu);//dogalgazın veri tabanıdaki değereini değiştirme
        int ledKontrol(evDurumu ev); // rasperry için led kontrolü
        int gazKontrol(evDurumu ev);// uygulama için gaz kontrolü
        bool gazSensorKapa(evDurumu evDurumu);//uygulama tarafında veri tabanına gaz sensoru var mı yok mu diye kayıt atmak
        bool hareketSenKapa(evDurumu evDurumu);// uygulama tarafında set inervali kapatmak için veritabanında hareket varmıyı 0 yapmak
        int hareketKontrol(evDurumu ev);// hareket varmı yok mu uygulama tarafında kontrol
        int kapıKontrolhareketKontrol(evDurumu ev); //kapı hareketi var mı yok mu uygulama tarafında kotrol
        bool kapıHareketSenKapa(evDurumu ev); //uygulama tarafında set inervali kapatmak için veritabanında hareket varmıyı 0 yapmak
    }
}
