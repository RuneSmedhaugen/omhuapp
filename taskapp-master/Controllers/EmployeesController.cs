using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskApp.API.Data;

namespace TaskApp.API.Controllers {

    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase {
        private readonly ITaskRepository _repo;

        public EmployeesController(ITaskRepository repo) {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployees() {
            var employees = await _repo.GetEmployees();
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployee(int id) {
            var employee = await _repo.GetEmployee(id);
            return Ok(employee);
        }
    }

}