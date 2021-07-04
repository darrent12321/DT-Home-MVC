using DTBlog.Models;
using DTBlog.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DTBlog.Controllers {
    public class HomeController : Controller {
        
        private readonly IBlogRepository _blogRepository;
        public HomeController(IBlogRepository blogRepository){
            _blogRepository = blogRepository;
        }
        
        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel();
            homeViewModel.AllBlogsDesc = _blogRepository.AllBlogs.OrderByDescending(blog => blog.PostDate);
            return View(homeViewModel);
            
            // var homeViewModel = new HomeViewModel(_blogRepository);
            // return View(homeViewModel.AllBlogsDesc);
        }

        public IActionResult PartialVs()
        {
            return View();
        }
    }
}