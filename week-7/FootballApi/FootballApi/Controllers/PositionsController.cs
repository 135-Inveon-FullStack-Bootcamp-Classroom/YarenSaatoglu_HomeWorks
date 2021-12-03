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
    public class PositionsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public PositionsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Position>>> GetPositions()
        {
            var positions = await _unitOfWork.PositionService.GetAllAsync();
            return Ok(positions);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Position>> GetPosition(int id)
        {
            var position = await _unitOfWork.PositionService.GetAsync(id);
            return Ok(position);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPosition(int id, Position position)
        {
            await _unitOfWork.PositionService.UpdateAsync(id, position);
            return NoContent();
        }

        [HttpPost("{id}/add-footballer")]
        public async Task<IActionResult> AddFootballer(int id, [FromBody] Footballer footballer)
        {
            footballer.Positions = (ICollection<Position>)await _unitOfWork.PositionService.GetAsync(id);
            var createFootballer = await _unitOfWork.FootballerService.CreateAsync(footballer);

            return Ok(createFootballer);
        }

        [HttpPost]
        public async Task<ActionResult<Position>> PostPosition(Position position)
        {
            var createdPosition = await _unitOfWork.PositionService.CreateAsync(position);
            //await _unitOfWork.SaveChangesAsync();
            return Ok(createdPosition);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePosition(int id)
        {
            await _unitOfWork.PositionService.DeleteAsync(id);
            return NoContent();
        }
    }
}
