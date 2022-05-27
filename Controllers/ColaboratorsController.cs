using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using loja_depr.Models.Colaborator;
using loja_depr.Repositories;
using loja_depr.DAL;

namespace loja_depr.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ColaboratorsController : Controller
    {
        private readonly StoreDepartContext _context;
        private IColaboratorsRepository _repository;

        public ColaboratorsController(StoreDepartContext context)
        {
            _context = context;

            _repository = _context.GetColaboratorsRepository();
        }

        [HttpGet("[action]")]
        public IActionResult GetColaborators()
        {
            try
            {
                List<Colaborators> colaborators = _repository.GetAll().ToList();

                if(colaborators.Count == 0)
                {
                    return BadRequest("Não há colaboradores cadastrados.");
                }

                return Ok(colaborators);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        [HttpGet("[action]")]
        public IActionResult GetColaborator(int id)
        {
            try
            {
                Colaborators colaborator = _repository.GetById(id);

                if(colaborator == null)
                {
                    return BadRequest("Não há colaborador cadastrado com esse ID.");
                }

                return Ok(colaborator);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        [HttpPost("[action]")]
        public IActionResult Insert([FromBody] Colaborators colaborator)
        {
            try
            {
                if(colaborator == null)
                {
                    return BadRequest("Não há colaborador para ser inserido.");
                }

                _repository.Add(colaborator);
                _context.SaveChanges();

                return Ok();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        [HttpPut("[action]")]
        public IActionResult Update([FromBody] Colaborators colaborator)
        {
            try
            {
                if(colaborator == null)
                {
                    return BadRequest("Não há colaborador para ser atualizado.");
                }

                _repository.Update(colaborator);
                _context.SaveChanges();

                return Ok();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        [HttpDelete("[action]")]
        public IActionResult Delete(int id)
        {
            try
            {
                Colaborators colaborator = _repository.GetById(id);

                if(colaborator == null)
                {
                    return BadRequest("Não há colaborador para ser deletado.");
                }

                _repository.Remove(colaborator);
                _context.SaveChanges();

                return Ok();
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}