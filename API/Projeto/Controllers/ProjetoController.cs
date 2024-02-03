using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Projeto.Data;
using Projeto.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MeuProjeto.Controllers
{

    [ApiController]
    [Route("api/[controller]")]

    public class ProjetoController: ControllerBase
    {

        private readonly DataContext _dataContext;

        public ProjetoController(DataContext dataContext){
            _dataContext = dataContext;
        }


        [HttpGet]
        
        public async Task<ActionResult<IEnumerable<ProjetoAgencia>>> GetProjeto()
        {
            return await _dataContext.Projeto.ToListAsync();
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<ProjetoAgencia>> GetProjetoById(int id)
        {
            var MeuProjeto = await _dataContext.Projeto.FindAsync(id);
            if (MeuProjeto == null)
            {
            return NotFound();
            }

            return Ok(MeuProjeto);
        }
        
    }
}