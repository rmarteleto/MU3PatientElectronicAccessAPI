using Microsoft.AspNetCore.Mvc;
using Hl7.Fhir.Model;

namespace MUS3.PatientElectronicAccess.API.Controllers
{
    [Route("api/patient")]
    public class PatientsController: Controller
    {
        /// <summary>
        /// Get patient by id
        /// </summary>
        /// <param name="id"></param>
        /// <response code="200">Successful operation</response>
        /// <response code="400">Invalid parameter</response>
        /// <response code="401">Unauthorized request</response>
        /// <response code="403">Insufficient scope</response>
        /// <response code="404">Unknown resource</response>
        /// <response code="410">Deleted resource</response>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // to-do: need to filter patient from database
            var patient = new Patient();
            if (patient == null)
                return NotFound();

            return Ok(patient);
        }

        /// <summary>
        /// Get patient by identifier
        /// </summary>
        /// <param name="identifier"></param>
        /// <response code="200">Successful operation</response>
        /// <response code="400">Invalid parameter</response>
        /// <response code="401">Unauthorized request</response>
        /// <response code="403">Insufficient scope</response>
        /// <response code="404">Unknown resource</response>
        /// <response code="410">Deleted resource</response>
        [HttpGet]
        public IActionResult GetByIdentifier(string identifier)
        {
            if (string.IsNullOrWhiteSpace(identifier))
                return BadRequest();

            string[] ids = identifier.Split('|');
            if (ids.Length != 2)
                return BadRequest();

            string system = ids[0];
            string code = ids[1];

            // to-do: this is how to search by string: http://hl7.org/fhir/DSTU2/search.html#string
            // to-do: need to filter patient from database
            var patient = new Patient();
            if (patient == null)
                return NotFound();

            return Ok(patient);
        }


        /// <summary>
        /// Get patient by name and birth date
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dob"></param>
        /// <response code="200">Successful operation</response>
        /// <response code="400">Invalid parameter</response>
        /// <response code="401">Unauthorized request</response>
        /// <response code="403">Insufficient scope</response>
        /// <response code="404">Unknown resource</response>
        /// <response code="410">Deleted resource</response>
        [HttpGet]
        public IActionResult GetByNameBoD(string name, string dob)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(dob))
                return BadRequest();

            // to-do: need to filter patient from database
            var patient = new Patient();
            if (patient == null)
                return NotFound();

            return Ok(patient);
        }

        /// <summary>
        /// Get patient by name and gender
        /// </summary>
        /// <param name="name"></param>
        /// <param name="gender"></param>
        /// <response code="200">Successful operation</response>
        /// <response code="400">Invalid parameter</response>
        /// <response code="401">Unauthorized request</response>
        /// <response code="403">Insufficient scope</response>
        /// <response code="404">Unknown resource</response>
        /// <response code="410">Deleted resource</response>
        [HttpGet]
        public IActionResult GetByNameGender(string name, string gender)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(gender))
                return BadRequest();

            // to-do: need to filter patient from database
            var patient = new Patient();
            if (patient == null)
                return NotFound();

            return Ok(patient);
        }

        /// <summary>
        /// Get patient by family and gender
        /// </summary>
        /// <param name="family"></param>
        /// <param name="gender"></param>
        /// <response code="200">Successful operation</response>
        /// <response code="400">Invalid parameter</response>
        /// <response code="401">Unauthorized request</response>
        /// <response code="403">Insufficient scope</response>
        /// <response code="404">Unknown resource</response>
        /// <response code="410">Deleted resource</response>
        [HttpGet]
        public IActionResult GetByFamilyGender(string family, string gender)
        {
            if (string.IsNullOrWhiteSpace(family) || string.IsNullOrWhiteSpace(gender))
                return BadRequest();

            // to-do: need to filter patient from database
            var patient = new Patient();
            if (patient == null)
                return NotFound();

            return Ok(patient);
        }

        /// <summary>
        /// Get patient by given and gender
        /// </summary>
        /// <param name="given"></param>
        /// <param name="gender"></param>
        /// <response code="200">Successful operation</response>
        /// <response code="400">Invalid parameter</response>
        /// <response code="401">Unauthorized request</response>
        /// <response code="403">Insufficient scope</response>
        /// <response code="404">Unknown resource</response>
        /// <response code="410">Deleted resource</response>
        [HttpGet]
        public IActionResult GetByGivenGender(string given, string gender)
        {
            if (string.IsNullOrWhiteSpace(given) || string.IsNullOrWhiteSpace(gender))
                return BadRequest();

            // to-do: need to filter patient from database
            var patient = new Patient();
            if (patient == null)
                return NotFound();

            return Ok(patient);
        }
    }
}
