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
    public class OnlyForPutController : ApiController
    {
        private IKullaniciService kullaniciService = new KullaniciService();
       

        // POST: api/OnlyForPut
        public kullanici Post([FromBody]kullanici kullanici)
        {
            var a = kullanici.kullaniciAdi;
            var b = kullaniciService.getKullanici2(a);
            if (b != null)
            {
                return b;
            }
            return null;
        }

     
    }
}
