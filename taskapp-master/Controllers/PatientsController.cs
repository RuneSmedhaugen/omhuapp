using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskApp.API.Data;

namespace TaskApp.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class PatientsController : ControllerBase
    {
        private readonly ITaskRepository _repo;

        public PatientsController(ITaskRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetPatients()
        {
            var patients = await _repo.GetPatients();
            return Ok(patients);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPatient(int id)
        {
            var patient = await _repo.GetPatient(id);
            if (patient == null) return NotFound();
            return Ok(patient);
        }
    }
}