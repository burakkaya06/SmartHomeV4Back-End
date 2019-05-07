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
    public class OpenCloseController : ApiController
    {
        private IKullaniciService kullaniciService = new KullaniciService();



        public string Get(int id)
        {
            return "value";
        }

        // PUT: api/OpenClose/5
        public evDurumu Post([FromBody]evDurumu evDurumu)
        {
            return kullaniciService.openClose(evDurumu);
        }

       
    }
}
