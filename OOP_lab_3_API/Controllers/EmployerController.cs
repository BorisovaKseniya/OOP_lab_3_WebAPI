using Microsoft.AspNetCore.Mvc;

namespace OOP_lab_3_API.Controllers
{

    [ApiController]
    [Route("api/[Controller]")]
    public class EmployerController : ControllerBase
    {

        private static Employer employer = new Employer();
        // это типа getone
        [HttpGet]
        public ActionResult <Employer> Get()
        {
            return Ok(employer);
        }



    }
}
