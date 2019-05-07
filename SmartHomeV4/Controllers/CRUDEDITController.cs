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
    public class CRUDEDITController : ApiController
    {
        private IKullaniciService kullaniciService = new KullaniciService();

        // POST: api/CRUDEDIT
        public bool POST([FromBody]kullanici kullanici)
        {
            return kullaniciService.updateKullanici(kullanici);


        }

    }
}
