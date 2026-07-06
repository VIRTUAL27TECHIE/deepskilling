using Microsoft.AspNetCore.Mvc;using Microsoft.IdentityModel.Tokens;using System.IdentityModel.Tokens.Jwt;using System.Security.Claims;using System.Text;using MicroservicesJWT.Models;
namespace MicroservicesJWT.Controllers;
[ApiController][Route("api/[controller]")]
public class AuthController:ControllerBase{
[HttpPost("login")]
public IActionResult Login(LoginModel m){if(m.Username=="admin"&&m.Password=="admin123"){var c=new[]{new Claim(ClaimTypes.Name,m.Username),new Claim(ClaimTypes.Role,"Admin")};var k=new SymmetricSecurityKey(Encoding.UTF8.GetBytes("ThisIsASecretKeyForJwtToken"));var t=new JwtSecurityToken("MyAuthServer","MyApiUsers",c,expires:DateTime.Now.AddMinutes(60),signingCredentials:new SigningCredentials(k,SecurityAlgorithms.HmacSha256));return Ok(new{Token=new JwtSecurityTokenHandler().WriteToken(t)});}return Unauthorized(new{Message="Invalid credentials"});}}