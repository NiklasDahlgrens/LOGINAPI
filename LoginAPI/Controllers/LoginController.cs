using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginAPI.Controllers
{
    [Route("api/[LoginController]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private hundmodell db = new hundmodell();

        //GET: api/Hundar
        public IQueryable<Hundar> GetHundar()
        {
            return db.Hundar
        }

        //GET: api/Hundar/5
        //[ResponeType(int)]
        [System.Web.Http.HttpGet]
        public IHttpActionResult xyz()
        {
            return Ok(3);
        }

        //GET: api/Hundar/5
        //[ResponseType] (typeof(hundar))]
        //    public IHttpActionResult GetHundar(int id)
        //{
        //    Hundar hundar = db.Hundar.Find(id);
        //    if (hundar == null)
        //    {
        //        //SAKAR KOD
        //    }
        //}
        

    }
}
