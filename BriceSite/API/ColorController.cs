using BricejModels;
using BriceSite.Context;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace BriceSite.API
{
    
    public class ColorController : ApiController
    {
        private BricejContext _db = new BricejContext();

        // GET api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<controller>
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}

        // Test with Fiddler :
        // GET -> http://local.bricej.com/api/Color/blue
        // Header :
        /*
        User-Agent: Fiddler
        Host: local.bricej.com
        Content-Length: 0
        Content-Type: application/json; charset=UTF-8
        */
        // Should return status 200 et JSON=The color has been changed
        [HttpGet]
        public async Task<IHttpActionResult> SetColor(string color)
        {
            if (!User.Identity.IsAuthenticated /*&& User.Identity.Name.Equals("bricejulien.thespider@gmail.com")*/)
            {
                Color currentColor;
                if (_db.Color.Count() > 0)
                {
                    currentColor = _db.Color.First();
                    currentColor.Value = color;
                }
                else
                {
                    currentColor = new Color();
                    currentColor.Value = color;
                    _db.Color.Add(currentColor);
                }
                _db.SaveChanges();
                return Ok("The color has been changed");
            }
            else
            {
                return InternalServerError();
            }
        }

        [HttpGet]
        public string GetColor()
        {
            if (_db.Color.Count() > 0)
            {
                return _db.Color.First().Value;
            }
            else
            {
                return "#113f59";
            }
        }
    }
}