using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarChart.Data;
using StarChart.Models;

namespace StarChart.Controllers
{
    [Route("")]
    [ApiController]
    public class CelestialObjectController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CelestialObjectController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int Id)
        {
            CelestialObject obj = _context.CelestialObjects.Where(o => o.Id == Id).FirstOrDefault();
            if (obj == null) return NotFound();
            //obj.Satellites.Add(_context.CelestialObjects.Where(o => o.OrbitedObjectId == Id));
            return Ok(obj);
        }

        [HttpGet("{name}")]
        public IActionResult GetByName(string name)
        {
            CelestialObject obj = _context.CelestialObjects.Where(o => o.Name == name).FirstOrDefault();
            if (obj == null) return NotFound();
            return Ok(obj);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<CelestialObject> objs = _context.CelestialObjects.ToList();
            return Ok(objs);
        }
    }
}
