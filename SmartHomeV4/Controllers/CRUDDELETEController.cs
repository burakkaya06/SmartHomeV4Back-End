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
    public class CRUDDELETEController : ApiController
    {
        private IKullaniciService kullaniciService = new KullaniciService();

        // POST: api/CRUDDELETE
        public int Post([FromBody]kullanici kull)
        {
            if (kull.kullaniciAdi == "admin")
            {
                return 3;
            }


            var a = kullaniciService.Delete2(kull.kullaniciAdi);



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
