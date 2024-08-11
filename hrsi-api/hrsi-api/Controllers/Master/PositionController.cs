using hrsi_api.Data;
using Microsoft.AspNetCore.Mvc;

namespace hrsi_api.Controllers.Master
{
    [Route("api/master/[controller]")]
    public class PositionController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public PositionController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllPosition()
        {
            var allPosition = dbContext.position.ToList();

            return Ok(allPosition);
        }
    }
}
