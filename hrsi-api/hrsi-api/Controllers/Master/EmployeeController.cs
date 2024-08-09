using hrsi_api.Data;
using Microsoft.AspNetCore.Mvc;

namespace hrsi_api.Controllers.Master
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public EmployeeController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetAllEmployee ()
        {
            var allEmployee = dbContext.employee.ToList();

            return Ok(allEmployee);
        }
    }
}
