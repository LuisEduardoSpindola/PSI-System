using Microsoft.AspNetCore.Mvc;
using PSI.Application.Interface;

namespace PSI.Application.Controllers
{
    public class PostController : Controller
    {
        public IRepositoryPost Post { get; set; }

        public PostController(IRepositoryPost _Post)
        {
            _Post = Post;
        }



        public IActionResult Get()
        {
            return View();
        }
    }
}
