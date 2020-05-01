using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLOGAPP.Models
{
    public class Blog
    {
        // eger ıd isminden farklı bir isimde  ıd kullanmak istersen 
        // bunu [key] ile birincil anahtaar olduğunu belirtmen gerkiyor.
        public int Id { get; set; }
        public string Baslık { get; set; }
        public string  Acıklama { get; set; }
        public string  Resim{ get; set; }
        public string Icerik { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public bool Onay { get; set; }
        public bool Anasayfa { get; set; }

       
        // BURASI ONEMLİ BLOG SAYFASINI KATEGORİ SAYFASIYLA BAGLADIK 
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}