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
    public class kullaniciController : ApiController
    {
        private IKullaniciService kullaniciService = new KullaniciService();
        // GET: api/kullanici
        public List<kullanici> Get()
        {
            return kullaniciService.GetKullanici();
        }

        // GET: api/kullanici/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/kullanici
        public kullanici Post([FromBody]kullanici kullanici)
        {
            var a = kullanici.kullaniciAdi;
            var b = kullanici.password;
            return kullaniciService.GirisKontrol3(a, b);
        }

        // PUT: api/kullanici/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/kullanici/5
        public void Delete(int id)
        {
        }
    }
}
