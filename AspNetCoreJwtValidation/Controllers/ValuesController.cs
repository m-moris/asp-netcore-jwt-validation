using System;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreJwtValidation.Controllers
{

    public class ValuesController : Controller
    {
        [Authorize(Roles = "admin")]
        [Route("api/values/admin")]
        [HttpGet()]
        public ActionResult GetOnlyAdmin()
        {
            return new JsonResult(new Dictionary<string, string>()
            {
                {"Message","GetOnlyAdmin() : Success"},
                {"DateTime", DateTime.UtcNow.ToString(CultureInfo.CurrentCulture) }
            });
        }
        [Authorize]
        [Route("api/values/user")]
        [HttpGet]
        public ActionResult Get()
        {
            return new JsonResult(new Dictionary<string, string>()
            {
                {"Message","Get() : Success"},
                {"DateTime", DateTime.UtcNow.ToString(CultureInfo.CurrentCulture) }
            });
        }
    }
}
