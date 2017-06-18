using Microsoft.AspNetCore.Mvc;
using mus3api.Model;

namespace mus3api.Controllers
{
    [Route("api/[controller]")]
    public class PatientController : Controller
    {
        // GET api/values/5
        [HttpGet("{id}")]
        public Patient Get(int id)
        {
            return new Patient();
        }
    }
}
