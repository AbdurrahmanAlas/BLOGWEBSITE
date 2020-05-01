using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLOGAPP.Models
{
    public class BlogModel
    {
        public int Id { get; set; }
        public string Baslık { get; set; }
        public string Acıklama { get; set; }
        public string Resim { get; set; }

        public DateTime EklenmeTarihi { get; set; }
        public bool Onay { get; set; }
        public bool Anasayfa { get; set; }
    }
}