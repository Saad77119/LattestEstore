using Microsoft.AspNetCore.Http;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EStore.Shared.Models;
using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Authorization;
using EStore.Client;

namespace EStore.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class admindashbordController : ControllerBase
    {
      //  [Authorize]
        // GET: admindashbord
       // public ActionResult Index()
       // {

          //  return View('');
      //  }
    }
}
