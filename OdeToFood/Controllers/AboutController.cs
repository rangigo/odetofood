using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    // about
    [Route("company/[controller]/[action]")]
    public class AboutController
    {
        public string Phone()
        {
            return "1+12312+1231231";
        }
        public string Address()
        {
            return "USA";
        }
    }
}
