using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ParcialWeb21100165.Data;
using ParcialWeb21100165.Interfaces;

namespace ParcialWeb21100165.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetencyController : ControllerBase
    {
        private readonly ICompetencyRepository _competencyRepository;

        public CompetencyController(ICompetencyRepository competencyRepository)
        {
            _competencyRepository = competencyRepository;
        }

        [HttpGet()]
        public async Task<IActionResult> GetAll()
        {
            var competencies = await _competencyRepository.GetAll();
            return Ok(competencies);
        }


        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] Competency competencies)
        {
            int eventId = await _competencyRepository.Insert(competencies);
            return Ok(eventId);
        }


        [HttpPut]
        public async Task<IActionResult> Update(int id, [FromBody] Competency competencies)
        {
            if (id != competencies.Id) return BadRequest();

            var result = await _competencyRepository.Update(competencies);
            if (!result) return NotFound();
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _competencyRepository.Delete(id);
            if (!result) return NotFound();
            return Ok(result);
        }
    }
}
