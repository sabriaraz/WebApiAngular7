using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PersonelProject.DTOs;
using static PersonelProject.Respository.Repository;

namespace PersonelProject.Controllers
{
    public class PersonelController : Controller
    {
        PersonelRepository _personelRep;
        public PersonelController(PersonelRepository personelRep)
        {
            _personelRep = personelRep;
        }

        public IActionResult Liste()
        {
            ICollection<PersonelDTO> pList = _personelRep.Doldur();
            return Json(pList);
        }
    }
}