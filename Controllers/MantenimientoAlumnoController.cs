using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SolExamen2.DataAccess;
using SolExamen2.Models;
using System.Collections.Generic;
using System.Linq;

namespace SolExamen2.Controllers
{
    public class MantenimientoAlumnoController : Controller
    {
        private readonly IMapper _mapper;
        private readonly MantenimientoContext _context;

        public MantenimientoAlumnoController(MantenimientoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IActionResult ListaAlumno()
        {
            

            return View();
        }

        public IActionResult RegistroAlumno()
        {
 
            return View();
        }
    }
}

