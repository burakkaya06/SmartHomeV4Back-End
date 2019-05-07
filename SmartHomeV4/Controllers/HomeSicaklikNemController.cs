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
    public class HomeSicaklikNemController : ApiController
    {

        private IKullaniciService kullaniciService = new KullaniciService();

        // POST: api/HomeSicaklikNem
        public bool Post([FromBody]evDurumu evDurumu)
        {
            var a = kullaniciService.updateHome(evDurumu);

            if (a == true)
            {
                return true;
            }
           else
            {
                return false;
            }

        }

    }
}
