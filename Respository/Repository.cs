using PersonelProject.Data;
using PersonelProject.DTOs;
using PersonelProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonelProject.Respository
{
    public class Repository
    {
        public class PersonelRepository: BaseRepository<Personel>
            
        {
            public PersonelRepository(PersonelContext db) : base(db)
            {

            }
            public async Task<ICollection<Personel>> Doldurs()
            {
                return await ListAll();

            }
            public ICollection<PersonelDTO> Doldur()
            {
                return Set().Select(x => new PersonelDTO
                {
                    personelId = x.PersonelId,
                    personelAd = x.PersonelAd,
                    personelSoyad = x.PersonelSoyad,
                    resimYol = x.ResimYol,
                    sehirId = x.SehirId,
                    sehirAd = x.Sehir.SehirAd,
                }).ToList();

            }

        }

        public class SehirRepository : BaseRepository<Sehir>

        {
            public SehirRepository(PersonelContext db) : base(db)
            {

            }

            public async Task<ICollection<Sehir>> Doldurs()
            {
                return await ListAll();

            }
            public ICollection<SehirDTO> Doldur()
            {
                return Set().Select(x => new SehirDTO
                {
                    sehirAd = x.SehirAd,
                    sehirId = x.SehirId,
                    resimYol = x.ResimYol
                }).ToList();
              
            }
            public Sehir Bul (int Id)
            {
                return Bul(Id);
            }

        }

        public class PerGaleriRepository : BaseRepository<PerGaleri>

        {
            public PerGaleriRepository(PersonelContext db) : base(db)
            {

            }
          
        }

        public class SehirGaleriRepository : BaseRepository<SehirGaleri>

        {
            public SehirGaleriRepository(PersonelContext db) : base(db)
            {

            }
        }

    }
}
