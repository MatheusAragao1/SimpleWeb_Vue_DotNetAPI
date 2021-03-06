using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using testeef.Data;
using testeef.Models;

namespace testeef.Controllers{

    [ApiController]
    [Route("v1/pessoas")]

    public class PessoaController : ControllerBase{

        [HttpGet]
        [Route("")]

        public async Task<ActionResult<List<Pessoa>>> Get ([FromServices] DataContext context){

            var pessoas = await context.Pessoa.ToListAsync();
            return pessoas; 
        }

        [HttpPost]
        [Route("")]

        public async Task<ActionResult<Pessoa>> Post( [FromServices] DataContext context, [FromBody] Pessoa model){

                if (ModelState.IsValid){
                    context.Pessoa.Add(model);
                    await context.SaveChangesAsync();
                    return model;
                }else{
                    return BadRequest(ModelState);
                }
            }
    }

}
