using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Salud.BD.Data;
using Salud.BD.Data.Entity;

namespace Salud.Server.Controllers
{
    [ApiController]
    [Route("api/profesion")]
    public class ProfesionController : ControllerBase
    {
        private readonly Context context;

        public ProfesionController(Context context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Profesion>>> Get()
        {
            return await context.Profesiones.ToListAsync();
        }


        [HttpGet("{id:int}")] // api/profesion/5
        public async Task<ActionResult<Profesion>> Get(int id)
        {
            var prof = await context.Profesiones.FirstOrDefaultAsync(x => x.Id == id);

            if (prof == null)
            {
                return NotFound($"el Id = {id} no fue encontrado");
            }
            return prof;


            //var existe = await context.Profesiones.AnyAsync(x => x.Id == id);
            //if (!existe)
            //{
            //    return NotFound($"el Id = {id} no fue encontrado");
            //}
            //return await context.Profesiones.FirstOrDefaultAsync(x => x.Id == id);

        }
    }
}
