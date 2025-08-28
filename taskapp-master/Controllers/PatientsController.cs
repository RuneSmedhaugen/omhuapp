using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskApp.API.Data;

namespace TaskApp.API.Controllers {
    
    [ApiController]
    [Route("api/[controller]")]
    public class PatientsController : ControllerBase {
        private readonly ITaskRepository _repo;

        public PatientsController(ITaskRepository repo) {
            _repo = repo;
        }
    }
}