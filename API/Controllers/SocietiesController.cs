using API.Entities;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SocietiesController : ControllerBase
    {
        private readonly ISocietyService _societyService;

        public SocietiesController(ISocietyService societyService)
        {
            _societyService = societyService;
        }

        [HttpPost]
        public IActionResult CreateSociety(CreateSocietyRequest request)
        {
            var society = new Society(
                request.Id,
                request.Name
            );

            _societyService.CreateSociety(society);
            
            var response = new SocietyResponse(
                society.Id,
                society.Name
            );

            return CreatedAtAction(
                actionName: nameof(GetSociety), 
                routeValues: new {id= society.Id}, 
                value: response);
        }

        [HttpGet()]
        public IActionResult GetSocieties()
        {
            var societies = _societyService.GetSocieties();
            return Ok(societies);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetSociety(int id)
        {
            var society = _societyService.GetSociety(id);

            var response = new SocietyResponse(
                society.Id,
                society.Name
            );

            return Ok(response);
        }

        [HttpPut("{id:int}")]
        public IActionResult UpsertSociety(int id, UpsertSocietyRequest request)
        {            
            var society = new Society(
                id,
                request.Name
            );

            _societyService.UpsertSociety(society);
        
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteSociety(int id)
        {   
            _societyService.DeleteSociety(id);
            return NoContent();
        }

        #region
        /*[HttpGet]
        public async Task<ActionResult<IEnumerable<Society>>> GetSocieties()
        {
            var societies = await _context.Societies.ToListAsync();
            return societies;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Society>> GetSociety(int id)
        {
            var society = await _context.Societies.FindAsync(id);
            return society;
        }

        [HttpPost]
        public void AddSociety(Society society)
        {
            _context.Societies.Add(society);
            _context.SaveChanges();
        }
        
        [HttpPut("{id}")]
        public void UpdateSociety(int id, Society society)
        {
            var societyInDb = _context.Societies.Find(id);
            societyInDb.Name = society.Name;
            _context.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void RemoveSociety(int id)
        {
            var society = _context.Societies.Find(id);
            _context.Societies.Remove(society);
            _context.SaveChanges();
        }*/
        #endregion
    }
}