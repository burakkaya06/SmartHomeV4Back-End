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
    public class openCloseGasController : ApiController
    {
        private IKullaniciService kullaniciService = new KullaniciService();

        // POST: api/openCloseGas
        public evDurumu Post([FromBody]evDurumu evDurumu)
        {
            return kullaniciService.openCloseGas(evDurumu);
        }

        
    }
}
