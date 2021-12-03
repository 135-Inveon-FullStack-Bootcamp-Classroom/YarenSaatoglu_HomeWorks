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
    public class FootballersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public FootballersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Footballer>>> GetFootballers()
        {
            var footballers = await _unitOfWork.FootballerService.GetAllAsync();
            return Ok(footballers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Footballer>> GetFootballer(int id)
        {
            var footballer = await _unitOfWork.FootballerService.GetAsync(id);
            return Ok(footballer);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutFootballer(int id, Footballer footballer)
        {
            await _unitOfWork.FootballerService.UpdateAsync(id, footballer);
            return NoContent();
        }

        [HttpPost("{id}/add-position")]
        public async Task<IActionResult> AddPosition(int id, [FromBody] Position position)
        {
            position.Footballers = (ICollection<Footballer>)await _unitOfWork.FootballerService.GetAsync(id);
            var createPosition = await _unitOfWork.PositionService.CreateAsync(position);

            return Ok(createPosition);
        }

        [HttpPost]
        public async Task<ActionResult<Footballer>> PostFootballer(Footballer footballer)
        {
            var createdFootballer = await _unitOfWork.FootballerService.CreateAsync(footballer);
            //await _unitOfWork.SaveChangesAsync();
            return Ok(createdFootballer);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFootballer(int id)
        {
            await _unitOfWork.FootballerService.DeleteAsync(id);
            return NoContent();
        }
    }
}
