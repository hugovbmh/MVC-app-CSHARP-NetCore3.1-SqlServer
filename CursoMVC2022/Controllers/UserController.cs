using CursoMVC2022.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC2022.Controllers
{
    public class UserController : Controller
    {
        
        public IActionResult Index()
        {
            List<User> lista = new List<User>();
            using (var db = new Models.DB.CursoMvcCoreContext())
            {
                lista = (from d in db.User
                         select new User
                         {
                             Id = d.Id,
                             Email = d.Email
                         }).ToList();
            }
            return View(lista);
        }
    }
}

//var user = new User();
//user.Name = "Hugo";
//user.Email = "hugovb@gmail.com";