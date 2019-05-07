using SmartHomeV4.Models;
using SmartHomeV4.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SmartHomeV4.Controllers
{
    public class CRUDController : ApiController
    {
        private IKullaniciService kullaniciService = new KullaniciService();

        // GET: api/CRUD
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/CRUD/5
        public kullanici Get(string kullaniciAdi)
        {
            return kullaniciService.getKullanici2(kullaniciAdi);
        }

        // POST: api/CRUD
        public bool Post([FromBody]kullanici kullanici)
        {
            return kullaniciService.SaveKullanici(kullanici);
        }

        // PUT: api/CRUD/5
        public bool Put([FromBody]kullanici kullanici)
        {
           return kullaniciService.updateKullanici(kullanici);

            
        }

        // DELETE: api/CRUD/5
        public int Delete([FromBody]kullanici kullanici)
        {
            if (kullanici.kullaniciAdi == "admin")
            {
                return 3;
            }


            var a = kullaniciService.Delete(kullanici.kullaniciAdi);

           

            if (a == true)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}
