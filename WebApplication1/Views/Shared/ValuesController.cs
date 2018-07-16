using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//using WebApplication1.Factory;
using HelloWorldClass;
namespace WebApplication1.Controllers
{
    public class ValuesController : ApiController
    {


        // GET api/values/Simple
        // 
        //public string Get(String DataType)
        public string Get(string id)
        {
            
            return HelloWorldClass.FactoryCreateHelloWorld.GetHellowWorld(id);
        }

        
    }
}
