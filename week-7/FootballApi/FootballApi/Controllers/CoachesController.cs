using FootballApi.Entities;
using FootballApi.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoachesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CoachesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Coach>>> GetCoachs()
        {
            var coaches = await _unitOfWork.CoachService.GetAllAsync();
            return Ok(coaches);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Coach>> GetCoach(int id)
        {
            var coach = await _unitOfWork.CoachService.GetAsync(id);
            return Ok(coach);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCoach(int id, Coach coach)
        {
            await _unitOfWork.CoachService.UpdateAsync(id, coach);
            return NoContent();
        }
        [HttpPost("{id}/add-tactic")]
        public async Task<IActionResult> AddPosition(int id, [FromBody] Tactic tactic)
        {
            tactic.Coach = await _unitOfWork.CoachService.GetAsync(id);
            var createTactic = await _unitOfWork.TacticService.CreateAsync(tactic);

            return Ok(createTactic);
        }

        [HttpPost]
        public async Task<ActionResult<Coach>> PostCoach(Coach coach)
        {
            var createdCoach = await _unitOfWork.CoachService.CreateAsync(coach);
            //await _unitOfWork.SaveChangesAsync();
            return Ok(createdCoach);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCoach(int id)
        {
            await _unitOfWork.CoachService.DeleteAsync(id);
            return NoContent();
        }
    }
}
