using Microsoft.AspNetCore.Authorization;using Microsoft.AspNetCore.Mvc;
namespace MicroservicesJWT.Controllers;
[ApiController][Route("api/[controller]")]
public class AdminController:ControllerBase{[Authorize(Roles="Admin")][HttpGet("dashboard")]public IActionResult Get()=>Ok("Welcome to the admin dashboard.");}