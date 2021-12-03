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
    public class TacticsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public TacticsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tactic>>> GetTactics()
        {
            var tactics = await _unitOfWork.TacticService.GetAllAsync();
            return Ok(tactics);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Tactic>> GetTactic(int id)
        {
            var tactic = await _unitOfWork.TacticService.GetAsync(id);
            return Ok(tactic);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutTactic(int id, Tactic tactic)
        {
            await _unitOfWork.TacticService.UpdateAsync(id, tactic);
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Tactic>> PostTactic(Tactic tactic)
        {
            var createdTactic = await _unitOfWork.TacticService.CreateAsync(tactic);
            //await _unitOfWork.SaveChangesAsync();
            return Ok(createdTactic);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTactic(int id)
        {
            await _unitOfWork.TacticService.DeleteAsync(id);
            return NoContent();
        }
    }
}
