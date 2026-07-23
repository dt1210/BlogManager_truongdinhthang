using BlogManager_truongdinhthang.Models;
using Microsoft.AspNetCore.Mvc;

public class LabController : Controller
{
    public IActionResult Index()
    {
        var baiViet = new List<Post>
        {
            new Post { Id = 1, Title = "C# co ban", IsPublished = true },
            new Post { Id = 2, Title = "MVC nhap mon", IsPublished = false },
            new Post { Id = 3, Title = "EF Core", IsPublished = true }
        };

        ViewBag.SoDaXuatBan = baiViet.Count (p => p.IsPublished);
        ViewBag.TieuDe = baiViet.Where (p => p.IsPublished)
               .OrderBy(p => p.Title).Select(p => p.Title).ToList();
        return View();
    }
}