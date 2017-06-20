using Microsoft.AspNetCore.Mvc;

namespace MUS3.PatientElectronicAccess.API.Controllers
{
    [Route("api/patient")]
    public class PatientsController: Controller
    {
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            // to-do: need to filter patient from database by id
            var patient = new Models.Patient();
            if (patient == null)
                return NotFound();

            return Ok(patient);
        }
    }
}
