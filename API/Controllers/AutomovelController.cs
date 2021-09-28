using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using API.Data;

namespace API.Controllers
{
    [ApiController]
    [Route("api/automovel")]
    public class AutomovelController : ControllerBase
    {
        private  readonly DataContext _context;

        public AutomovelController(DataContext context)
        {
            _context = context;
        }

        // POST: api/automovel/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody]Automovel automovel)
        {
            _context.Automovel.Add(automovel);
            _context.SaveChanges();
            return Created("", automovel);
        }

        // GET: api/automovel/list
        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.Automovel.ToList());

        // GET: api/automovel/getbyid/1
        [HttpGet]
        [Route("getbyid/{id}")]
        public IActionResult GetById( [FromRoute]int id)
        {
            Automovel automovel = _context.Automovel.Find(id);
            if (automovel == null)
            {
                return NotFound();
            }
            return Ok(automovel);
        }

        // DELETE: api/automovel/delete/Corsa
        [HttpDelete]
        [Route("delete/{modelo}")]

        public IActionResult Delete([FromRoute] string modelo)
        {
            //Buscar um objeto na tabela de produtos com base no modelo + Expressão lambda
            Automovel automovel = _context.Automovel.FirstOrDefault(automovel => automovel.Modelo == modelo);
            if (automovel == null)
            {
                return NotFound();
            }
            _context.Automovel.Remove(automovel);
            _context.SaveChanges();
            return Ok(_context.Automovel.ToList());
        }

        // PUT: api/automovel/update
        [HttpPut]
        [Route("update")]
        public IActionResult Update([FromBody]Automovel automovel)
        {
            _context.Automovel.Update(automovel);
            _context.SaveChanges();
            return Ok(automovel);
        }
    }
}