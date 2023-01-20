using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        IEmployeeService _employeeService;
        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _employeeService.GetAll();
            if (result.Succes)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("login")]
        public IActionResult Login()
        {
            var result = _employeeService.GetUserDetails();
            if (result.Succes)
            {
                return Ok(result.Succes);
            }
            return BadRequest(result.Succes);
        }
    }
}
