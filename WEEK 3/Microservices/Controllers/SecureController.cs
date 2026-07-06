using Microsoft.AspNetCore.Authorization;using Microsoft.AspNetCore.Mvc;
namespace MicroservicesJWT.Controllers;
[ApiController][Route("api/[controller]")]
public class SecureController:ControllerBase{[Authorize][HttpGet("data")]public IActionResult Get()=>Ok("This is protected data.");}