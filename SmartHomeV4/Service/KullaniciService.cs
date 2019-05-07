using SmartHomeV4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHomeV4.Service
{
    public class KullaniciService : IKullaniciService
    {
        SmartHomeEntities context = new SmartHomeEntities();

        public bool Delete(string kullaniciAdi)
        {
            var a = context.kullanici.Where(l => l.kullaniciAdi == kullaniciAdi).FirstOrDefault();
            
            if (a != null)
            {
                var b = a.kullaniciId;
                context.kullanici.Remove(context.kullanici.Find(b));
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public bool Delete2(string kullaniciAdi)
        {
            var a = context.kullanici.Where(l => l.kullaniciAdi == kullaniciAdi).FirstOrDefault();

            if (a != null)
            {
                var b = a.kullaniciId;
                context.kullanici.Remove(context.kullanici.Find(b));
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }

        public List<kullanici> GetKullanici()
        {
            return context.kullanici.ToList();
            
        }


        public int GirisKontrol(string kullaniciAdi, string password)
        {
           

            var a = context.kullanici.Where(l => l.kullaniciAdi == kullaniciAdi).FirstOrDefault();
            if (a != null)
            {   
                var b = context.kullanici.Where(l => l.kullaniciAdi == kullaniciAdi && l.password == password).FirstOrDefault();
                if (b != null)
                {
                    if (kullaniciAdi == "admin")
                    {
                        return 4;
                    }
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                return 3;
            }
        }
        public string GirisKontrol2(string kullaniciAdi,string password)
        {
            var a = context.kullanici.Where(l => l.kullaniciAdi == kullaniciAdi).FirstOrDefault();

            if (a != null)
            {
                var b = context.kullanici.Where(l => l.password == password).FirstOrDefault();
                if (b != null)
                {
                    if (kullaniciAdi == "admin")
                    {
                        return "admin";
                    }
                    return a.gercekKisiAdiSoyadi;
                }
                else
                {
                    return "yanlis";
                }
            }
            else
            {
                return "nokullanici";
            }

        }
        public kullanici GirisKontrol3(string kullaniciAdi,string password)
        {
            var a = context.kullanici.Where(l => l.kullaniciAdi == kullaniciAdi).FirstOrDefault();
            kullanici c = new kullanici();
            c.kullaniciAdi = "tanımsiz";

            if (a != null)
            {
                var b = context.kullanici.Where(l => l.password == password).FirstOrDefault();
                if (b != null)
                {
                    return a;
                }
                else
                {
                    return c;
                }
            }
            else
            {
                c.kullaniciAdi = "nokullanici";
                return c;
            }
        }
        


        public bool SaveKullanici(kullanici kullanici)
        {
            //dublicated
            var çiftkayıtkontrolü = context.kullanici.Where(l => l.kullaniciAdi == kullanici.kullaniciAdi).ToList();

            if (çiftkayıtkontrolü.Count == 0)
            {
                try
                {
                    context.kullanici.Add(kullanici);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }

            }
            else
            {

                return false;
            }


        }

        public bool updateKullanici(kullanici kull)
        {

            var result = context.kullanici.Where(l => l.kullaniciId == kull.kullaniciId).FirstOrDefault();
            result.kullaniciAdi = kull.kullaniciAdi;
            result.password = kull.password;
            result.gercekKisiAdiSoyadi = kull.gercekKisiAdiSoyadi;
            result.email = kull.email;
            result.evDurumId = kull.evDurumId;

            if (result != null)
            {
                context.Entry(result).State = System.Data.Entity.EntityState.Modified;

                context.SaveChanges();
                return true;

            }
            return false;
            

            
           

        }

        public kullanici getKullanici2(string kullaniciAdi)
        {
           return context.kullanici.Where(l => l.kullaniciAdi == kullaniciAdi).FirstOrDefault();

        }

        public evDurumu getHome(int HomeId)
        {
             return context.evDurumu.Where(l => l.Id == HomeId).FirstOrDefault();
        }

        public bool updateHome(evDurumu evDurumu)
        {

            var result = context.evDurumu.Where(l => l.Id == 2).FirstOrDefault();
            result.anlikNem = evDurumu.anlikNem;
            result.anlikSıcaklik = evDurumu.anlikSıcaklik;
            result.hareketVarMi = evDurumu.hareketVarMi;
            result.dumanVarMi = evDurumu.dumanVarMi;
            result.suVanaDurumu = evDurumu.suVanaDurumu;

            if (result != null)
            {
                context.Entry(result).State = System.Data.Entity.EntityState.Modified;

                context.SaveChanges();
                return true;

            }
            return false;





        }
        public int kapıKontrolhareketKontrol(evDurumu ev){

            var a = context.evDurumu.Where(l => l.Id == ev.Id).FirstOrDefault();
            if (a != null)
            {
                if (a.dumanVarMi == true)
                {
                    return 1;
                }
                else
                    return 0;
            }
            return 2;

        }
        public bool kapıHareketSenKapa(evDurumu ev)
        {
            var result = context.evDurumu.Where(l => l.Id == 2).FirstOrDefault();

            result.dumanVarMi =ev.dumanVarMi ;


            if (result != null)
            {
                context.Entry(result).State = System.Data.Entity.EntityState.Modified;

                context.SaveChanges();
                return true;

            }
            return false;

        }



        public int hareketKontrol(evDurumu ev)
        {
            var a = context.evDurumu.Where(l => l.Id == ev.Id).FirstOrDefault();
            if (a != null)
            {
                if (a.hareketVarMi == true)
                {
                    return 1;
                }
                else
                    return 0;
            }
            return 2;

        }
        public bool hareketSenKapa(evDurumu evDurumu)
        {
            var result = context.evDurumu.Where(l => l.Id == 2).FirstOrDefault();

            result.hareketVarMi = evDurumu.hareketVarMi;
           

            if (result != null)
            {
                context.Entry(result).State = System.Data.Entity.EntityState.Modified;

                context.SaveChanges();
                return true;

            }
            return false;
        }

        public evDurumu openClose(evDurumu evDurumu) //ledin uygulama tarafında açıp kapama 
        {
            var result=context.evDurumu.Where(l => l.Id == evDurumu.Id).FirstOrDefault();

            result.elektrikAktifMi = evDurumu.elektrikAktifMi;

            if (result != null)
            {
                context.Entry(result).State = System.Data.Entity.EntityState.Modified;

                context.SaveChanges();
                return evDurumu;

            }
            return null;

        }

        public evDurumu openCloseGas(evDurumu evDurumu) //veri tabanında dogalgazın konumunu değiştirme
        {
            var result = context.evDurumu.Where(l => l.Id == evDurumu.Id).FirstOrDefault();

            result.dogalGazVanaDurumu = evDurumu.dogalGazVanaDurumu;

            if (result != null)
            {
                context.Entry(result).State = System.Data.Entity.EntityState.Modified;

                context.SaveChanges();
                return evDurumu;

            }
            return null;

        }

        //-----------------LED-RaSperry---------------------------

        public int ledKontrol(evDurumu ev)
        {
            var a = context.evDurumu.Where(l => l.Id == ev.Id).FirstOrDefault();
            if (a !=null)
            {
                if (a.elektrikAktifMi == true)
                {
                    return 1;
                }
                else
                    return 0;
            }
            return 2;
        }

        public int gazKontrol(evDurumu ev)
        {
            var a = context.evDurumu.Where(l => l.Id == ev.Id).FirstOrDefault();
            if (a != null)
            {
                if (a.suVanaDurumu == true)
                {
                    return 1;
                }
                else { return 0; }
            }
            return 2;

        }
        public bool gazSensorKapa(evDurumu evDurumu)
        {
            var result = context.evDurumu.Where(l => l.Id == 2).FirstOrDefault();

            result.suVanaDurumu = evDurumu.suVanaDurumu;


            if (result != null)
            {
                context.Entry(result).State = System.Data.Entity.EntityState.Modified;

                context.SaveChanges();
                return true;

            }
            return false;
        }



    }

    
}