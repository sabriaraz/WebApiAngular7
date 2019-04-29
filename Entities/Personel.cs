using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PersonelProject.Entities
{
    [Table("Personel")]
    public class Personel
    {
        [Key]
        public int PersonelId{ get; set; }
        public string PersonelAd { get; set; }
        public string PersonelSoyad { get; set; }
        public string ResimYol  { get; set; }
        public int SehirId { get; set; }
        [ForeignKey("SehirId")]
        public Sehir Sehir { get; set; }

        public ICollection<PerGaleri> PersGaleri { get; set; }

    }

    [Table("Sehir")]
    public class Sehir
    {
        [Key]
        public int SehirId  { get; set; }
        public string SehirAd  { get; set; }
        public string ResimYol { get; set; }
        public ICollection<Personel> Personel { get; set; }
        public ICollection<SehirGaleri> SehirGaleri { get; set; }
    }
    [Table("PerGaleri")]
    public class PerGaleri
    {
        [Key]
        public int Id { get; set; }
        public string Yol { get; set; }
        public int PersonelId  { get; set; }
        [ForeignKey("PersonelId")]
        public Personel Personel  { get; set; }
    }

    [Table("SehirGaleri")]
    public class SehirGaleri
    {
        [Key]
        public int Id { get; set; }
        public string Yol { get; set; }
        public int SehirId  { get; set; }
        [ForeignKey("SehirId")]
        public Sehir Sehir {get; set; }

    }
}
