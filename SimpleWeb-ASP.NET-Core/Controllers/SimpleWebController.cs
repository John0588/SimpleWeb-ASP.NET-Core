using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWeb_ASP.NET_Core.Controllers
{
    public class SimpleWebController : Controller
    {
        private SimpleWebRepository _simpleWebRepository = null;

        public SimpleWebController()
        {
            _simpleWebRepository = new SimpleWebRepository();
        }
    }
}
