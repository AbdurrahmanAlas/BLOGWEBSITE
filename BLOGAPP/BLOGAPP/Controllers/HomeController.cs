using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLOGAPP.Models;

namespace BLOGAPP.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private BlogContext context = new BlogContext();

        public ActionResult Index()                       //VARSAYILAN İNDEX METODU HOME ADINDA KLASÖR EKLENİR
        {
            var bloglar = context.Bloglar
                .Select(i=>new BlogModel()
                {
                         Id=i.Id,
                         
                         Baslık=i.Baslık.Length>100?i.Baslık.Substring(0,100)+"...":i.Baslık,
                         Acıklama=i.Acıklama,
                         EklenmeTarihi=i.EklenmeTarihi,
                         Anasayfa=i.Anasayfa,
                         Onay=i.Onay,
                         Resim=i.Resim


                })
        
                .Where(i => i.Onay == true && i.Anasayfa == true);
                    
   
          
            // index viewine bütün blogları gönderiyoruz.
            return View(bloglar.ToList());

        }
    }
}