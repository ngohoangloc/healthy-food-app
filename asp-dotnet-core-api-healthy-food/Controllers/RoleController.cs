using asp_dotnet_core_api_healthy_food.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace asp_dotnet_core_api_healthy_food.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        public static List<Role> roles = new List<Role>();
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(roles);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(String id) 
        {
            var role = roles.SingleOrDefault(r => r.id == Guid.Parse(id));
            return Ok(role);
        }
    }
}
