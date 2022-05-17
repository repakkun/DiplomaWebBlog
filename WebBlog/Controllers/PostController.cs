using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebBlog.Data;
using WebBlog.Models;

namespace WebBlog.Controllers
{
    public class PostController : Controller
    {
        private readonly ApplicationDbContext _db;

        public PostController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<User> objList = _db.Users;
            return View(objList);
        }

        public IActionResult CreatePost(User user)
        {
            return View();
        }
            
    }
}
