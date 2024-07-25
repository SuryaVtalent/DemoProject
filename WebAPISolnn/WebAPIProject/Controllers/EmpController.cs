using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace WebAPIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {

        public IActionResult GetNames()
        {
            try
            {
                List<string> Names = new List<string>();

                Names.Add("Kohli");
                Names.Add("Surya");
                Names.Add("Greeshma");
                Names.Add("Ivaan");
                Names.Add("Yuvraj");

                return Ok(Names);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
