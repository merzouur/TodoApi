using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("home/hello")]
    public class EtnaController : ControllerBase
    {
        public ActionResult<EtnaModel> Etna()
        {
            EtnaModel etna = new EtnaModel { Etna = "Hello World"};
            return etna;
        }
    }
}

public class EtnaModel
{
    public string Etna {get; set;}
}