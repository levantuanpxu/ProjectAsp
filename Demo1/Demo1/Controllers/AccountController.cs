
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Demo1.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public AccountController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            /* IEnumerable<Category> categories = _appDbContext.Categories.Include(p => p.Blogs);
             return View(categories);*/
            return View();
        }
        public IActionResult Register()
        {
           
            return View();
        }

        
    }
}
