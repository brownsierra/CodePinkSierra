using System.Diagnostics;
using CodePinkSierra.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;


public class UserController : Controller
{

    private MyContext db;

    public UserController(MyContext context)
    {
        db = context;
    }
    private int? uid
    {
        get
        {
            return HttpContext.Session.GetInt32("uid");
        }
    }
    
    [HttpGet("codepink/laelynn")]
    public IActionResult Laelynn() {
        return View("Laelynn");
    }
    [HttpGet("codepink/studentlogin")]
    public IActionResult Login() {
        return View("Login");
    }
}
