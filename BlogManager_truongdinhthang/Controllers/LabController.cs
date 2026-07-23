using BlogManager_truongdinhthang.Models;
using Microsoft.AspNetCore.Mvc;

public class LabController : Controller
{
    public IActionResult Index()
    {
        var baiViet = new List<Post>
        {
            new Post { Id = 1, Title = "C# co ban", IsPublished = true , ViewCount = 150, Author = "Thăng"},
            new Post { Id = 2, Title = "MVC nhap mon", IsPublished = false,ViewCount = 350, Author = "An" },
            new Post { Id = 3, Title = "EF Core", IsPublished = true ,ViewCount = 550, Author = "Huy" },
            new Post { Id = 4, Title = "bai1", IsPublished = true ,ViewCount = 800, Author = "Minh" },
            new Post { Id = 5, Title = "bai1", IsPublished = true ,ViewCount = 450, Author = "Nhi" }
        };

        // ViewBag.SoDaXuatBan = baiViet.Count (p => p.IsPublished);
        // ViewBag.TieuDe = baiViet.Where (p => p.IsPublished)
        //        .OrderBy(p => p.Title).Select(p => p.Title).ToList();
        ViewBag.DanhSach = baiViet
            .Where(p => p.IsPublished)
            .OrderByDescending(p => p.ViewCount)
            .ToList();

        ViewBag.TongLuotXem = baiViet.Sum(p => p.ViewCount);

        ViewBag.TopPost = baiViet
            .OrderByDescending(p => p.ViewCount)
            .FirstOrDefault();
        return View();
    }
}
