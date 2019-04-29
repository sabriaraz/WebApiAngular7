using Microsoft.EntityFrameworkCore;
using PersonelProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonelProject.Data
{
    public class PersonelContext: DbContext
    {
        public PersonelContext(DbContextOptions<PersonelContext> option): base(option)
        {

        }
        public DbSet<Personel> Personel { get; set; }
        public DbSet<PerGaleri> PerGaleri { get; set; }
        public DbSet<Sehir> Sehir { get; set; }
        public DbSet<SehirGaleri> SehirGaleri { get; set; }
        

    }
}
