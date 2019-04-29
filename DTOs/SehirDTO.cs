using PersonelProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonelProject.DTOs
{
    public class SehirDTO
    {
        // Angularda değişken isimleri küçük harf ile başlaması gerektiği için çıkış datamızda değişken adlarını küçük harf ile yapmamız gerekir.
        public int sehirId { get; set; }
        public string sehirAd { get; set; }
        public string resimYol  { get; set; }
        
    }
}
