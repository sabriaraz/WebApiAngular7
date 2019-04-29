using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PersonelProject.DTOs;
using PersonelProject.Entities;
using static PersonelProject.Respository.Repository;

namespace PersonelProject.Controllers
{
    public class SehirController : Controller
    {
        SehirRepository _sehirRep;
        IMapper _mapper;
        public SehirController(SehirRepository sehirRep, IMapper mapper)
        {
            _sehirRep = sehirRep;
            _mapper = mapper;
        }
        public JsonResult Liste()
        {
            ICollection<SehirDTO> sehirList = _sehirRep.Doldur();
            //ICollection<Sehir> sehirListAsyn = await _sehirRep.Doldurs();
            return Json(sehirList);
        }
        [HttpPost]
        public async Task<JsonResult> Guncelle([FromBody]SehirDTO sDTO)
        {
            Sehir s = new Sehir();
            //s.SehirAd = sDTO.sehirAd;
            //s.SehirId = sDTO.sehirId;
            s = _mapper.Map(sDTO, s);
            _sehirRep.Update(s);
            await _sehirRep.Commit();
            return Json(sDTO);
        }
        [HttpPost]
        public async Task<JsonResult> Ekle([FromBody]SehirDTO sDTO)
        {
            Sehir s = new Sehir();
            //s.SehirAd = sDTO.sehirAd;
            s = _mapper.Map(sDTO, s);
            s.SehirId = 0;
            _sehirRep.Add(s);
            await _sehirRep.Commit();
            return Json(sDTO);
        }
        [HttpPost]
        public async Task<JsonResult> Sil([FromBody]SehirDTO sDTO)
        {
            Sehir s = new Sehir();
            s.SehirAd = sDTO.sehirAd;
            s.SehirId = sDTO.sehirId;
            _sehirRep.Delete(s);
            await _sehirRep.Commit();
            return Json(sDTO);
        }
    }
}