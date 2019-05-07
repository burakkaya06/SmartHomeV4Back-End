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
    public class GazKontrolUygulamaController : ApiController
    {
        private IKullaniciService kullaniciService = new KullaniciService();

        // POST: api/GazKontrolUygulama
        public int Post([FromBody]evDurumu ev)
        {
            return kullaniciService.gazKontrol(ev);
        }

     
    }
}
