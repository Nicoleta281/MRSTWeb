using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Pet()
        {
            return View();
        }
        public ActionResult Team()
        {
            return View();
        }
        public ActionResult Gallery()
        {
            return View();
        }
        public ActionResult Tips()
        {
            return View();
        }
        private static List<BlogPost> blogPosts = new List<BlogPost>
{
    new BlogPost { Id = 1, Title = "Adopția schimbă vieți", ShortDescription = "Cum adopția poate face diferența pentru un animal.", Content = "Detalii despre procesul de adopție...", ImageUrl = "~/Content/images/image_1.jpg" },
    new BlogPost { Id = 2, Title = "Îngrijirea unui câine", ShortDescription = "Sfaturi utile pentru îngrijirea câinilor.", Content = "Ghid complet despre alimentație, igienă și dresaj...", ImageUrl = "~/Content/images/image_2.jpg" },
    new BlogPost { Id = 3, Title = "Pisicile și somnul", ShortDescription = "De ce dorm pisicile atât de mult?", Content = "Explicații științifice despre somnul pisicilor...", ImageUrl = "~/Content/images/image_3.jpg" },
        new BlogPost { Id = 4, Title = "Pisicile și somnul", ShortDescription = "De ce dorm pisicile atât de mult?", Content = "Explicații științifice despre somnul pisicilor...", ImageUrl = "~/Content/images/image_4.jpg" }

};

        public ActionResult Blog()
        {
            return View(blogPosts); // Trimite lista de postări către Blog.cshtml
        }

        public ActionResult BlogSingle(int id)
        {
            var post = blogPosts.FirstOrDefault(p => p.Id == id);
            if (post == null)
                return HttpNotFound();

            return View(post); // Trimite articolul selectat către `BlogSingle.cshtml`
        }
        public ActionResult Contact()
        {
            return View(); 
        }
        public ActionResult Vet()
        {
            return View();
        }
    }
}
