using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

// amac veritabanı seması içinde herhangi bir değişiklik yaptığğımda context 
// sınıfının baglı olduğu vt da da değişiklik oluyor ya vt nını komple sil 
// yada bir initializer sınıfıyla değişikliği otomatik oluşturma 


namespace BLOGAPP.Models
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {


            // kategoriler için listeledik  listeledikten sonra foreach döngüde eğer kategori eklenirse döngüye soktuk 
            List<Category> kategoriler = new List<Category>()
            {
                new Category(){ KategoriAd= "C#" },
                 new Category(){ KategoriAd="Asp.net MVC"},
                  new Category(){ KategoriAd="Asp.net WebForm"},
                   new Category(){ KategoriAd="Windows Form"},
                   new Category(){KategoriAd="java"},
                   new Category(){KategoriAd="C++"},
          
            };

            foreach (var item in kategoriler)
            {
                context.Kategoriler.Add(item);

            }
            context.SaveChanges();




            // blog ları listeledik listeledikten sonra döngüde foreach döngüsüne sokup tekrar ekleme yaptık 

            List<Blog> bloglar = new List<Blog>()
            {
                new Blog(){Baslık="C# PROGRAMLAMA HAKKINDA " ,Acıklama="C#  Programlama hakkında  ",EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=true,Onay=true,Icerik="C#  programlama hakkında,C dilinin temelleri Martin Richards tarafından geliştirilen BCPL adlı dil ile atılmıştır. Sonra, BCPL dilinden esinlenerek, Ken Thompson B adlı dili oluşturmuştur. B dili, C dilinin oluşturulmasında bir basamak olarak kullanılmıştır. Daha sonra ise, C dili Brian Kernighan ve Dennis Ritchie tarafından geliştirilmiştir.",Resim="1.jpg",CategoryId=1},
                new Blog(){Baslık="ASP.NET HAKKINDA " ,Acıklama="ASP.NET HAKKINDA ASP.NET HAKKINDA ",EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=true,Onay=true,Icerik="C#  delegates hakkındaC#  delegates hakkındaC#  delegates hakkındaC#  delegates hakkındaC#  delegates hakkındaC#  delegates hakkında",Resim="2.jpg",CategoryId=1},
                new Blog(){Baslık="ASP NET WEB FORM HAKKINDA" ,Acıklama="ASP NET WEB FORM HAKKINDA ASP NET WEB FORM HAKKINDA",EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=false,Onay=false,Icerik="C#  delegates hakkındaC#  delegates hakkındaC#  delegates hakkındaC#  delegates hakkındaC#  delegates hakkındaC#  delegates hakkında",Resim="c.jpg",CategoryId=2},
                new Blog(){Baslık="ASP NET MVC HAKKINDA " ,Acıklama="ASP NET MVC HAKKINDA ASP NET MVC HAKKINDA",EklenmeTarihi=DateTime.Now.AddDays(-20),Anasayfa=true,Onay=true,Icerik="C#  delegates hakkındaC#  delegates hakkındaC#  delegates hakkındaC#  delegates hakkındaC#  delegates hakkındaC#  delegates hakkında",Resim="1.jpg",CategoryId=3},
                new Blog(){Baslık="JAVA DİLİ PROGRAMLAMA  HAKKINDA " ,Acıklama="JAVA DİLİ PROGRAMLAMA  HAKKINDA JAVA DİLİ PROGRAMLAMA  HAKKINDA",EklenmeTarihi=DateTime.Now.AddDays(-30),Anasayfa=false,Onay=false,Icerik="C#  delegates hakkındaC#  delegates hakkındaC#  delegates hakkındaC#  delegates hakkındaC#  delegates hakkındaC#  delegates hakkında",Resim="2.jpg",CategoryId=2},
                new Blog(){Baslık="C++ PROGRAMLAMA DİLİ HAKKINDA " ,Acıklama="C#  delegates hakkında C#  delegates hakkında",EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=true,Onay=false,Icerik="C#  delegates hakkındaC#  delegates hakkındaC#  delegates hakkındaC#  delegates hakkındaC#  delegates hakkındaC#  delegates hakkında",Resim="2.jpg",CategoryId=2},
                new Blog(){Baslık="C# PROGRAMLAMA HAKKINDA" ,Acıklama="C#  delegates hakkında C#  delegates hakkında",EklenmeTarihi=DateTime.Now.AddDays(-40),Anasayfa=true,Onay=true,Icerik="C#  delegates hakkındaC#  delegates hakkındaC#  delegates hakkındaC#  delegates hakkındaC#  delegates hakkındaC#  delegates hakkında",Resim="1.jpg",CategoryId=2},
                new Blog(){Baslık="JAVASCRİPT PROGRAMLAMA HAKKINDA " ,Acıklama="C#  delegates hakkında C#  delegates hakkında",EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=true,Onay=true,Icerik="C#  delegates hakkındaC#  delegates hakkındaC#  delegates hakkındaC#  delegates hakkındaC#  delegates hakkındaC#  delegates hakkında",Resim="1.jpg",CategoryId=3},







            };
            foreach(var item in bloglar)
            {
                context.Bloglar.Add(item);

            }
            context.SaveChanges();
           

            base.Seed(context);
        }
    }
}