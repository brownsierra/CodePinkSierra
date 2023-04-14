using System.Diagnostics;
using CodePinkSierra.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;


public class DonateController : Controller
{

    private MyContext db;

    public DonateController(MyContext context)
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

}