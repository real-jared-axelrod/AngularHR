using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]                
        public string GetEmployees(){
            return "this will be a list of employees";
        }

        [HttpGet("{id}")]
        public string GetProduct(int id){
            return "this will be a single employee";
        }

    }
}