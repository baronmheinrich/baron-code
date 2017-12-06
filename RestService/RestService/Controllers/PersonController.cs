using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net;
using RestService.Model;

namespace RestService.Controllers
{
    //dotnet core
    [Produces("application/json")]
    [Route("api/Person")]
    public class PersonController : Controller
    {
        public IEnumerable<PersonRest> Get()
        {
            Response.StatusCode = (int)HttpStatusCode.OK;
            return new List<PersonRest>()
            {
                new PersonRest(){FName="f1", LName="b1"}
            };
        }

        //dotnet framework
       // public IEnumerable<PersonRest> Get()
        //{
         //   return Request.CreateResponse<T>(HttpStatusCode.OK, new List<PersonRest>()
         //   {
         //       new PersonRest(){FName="f1", LName = "b1"}
         //   });


        //}
    }
}