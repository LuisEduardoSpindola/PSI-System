using Microsoft.AspNetCore.Mvc;
using PSI.Application.Interface;
using PSI.Domain.Models;

public class PostController : Controller
{
    private readonly IRepositoryPost _Post;

    public PostController(IRepositoryPost Post)
    {
        _Post = Post;
    }

    // GET: /Post/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: /Post/Create
    [HttpPost]
    public IActionResult Create(Post post)
    {
        if (ModelState.IsValid)
        {
            _Post.Create(post);
            return RedirectToAction("Get");
        }
        return View(post);
    }

    // GET: /Post/Get
    public IActionResult Get()
    {
        var posts = _Post.Get();
        return View(posts);
    }

    // GET: /Post/Update/5
    public IActionResult Update(int Id)
    {
        var post = _Post.GetById(Id);
        return View(post);
    }

    // POST: /Post/Update/5
    [HttpPost]
    public IActionResult Update(Post post)
    {
        if (ModelState.IsValid)
        {
            _Post.Update(post);
            return RedirectToAction("Get");
        }
        return View(post);
    }

    // POST: /Post/Delete/5
    [HttpPost]
    public IActionResult Delete(Guid Id)
    {
        _Post.DeleteById(Id);
        return RedirectToAction("Get");
    }
}
