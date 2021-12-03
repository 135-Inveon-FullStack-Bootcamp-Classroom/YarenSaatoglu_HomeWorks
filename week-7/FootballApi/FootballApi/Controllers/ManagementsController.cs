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
    public class ManagementsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ManagementsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Management>>> GetManagements()
        {
            var managements = await _unitOfWork.ManagementService.GetAllAsync();
            return Ok(managements);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Management>> GetManagement(int id)
        {
            var management = await _unitOfWork.ManagementService.GetAsync(id);
            return Ok(management);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutManagement(int id, Management management)
        {
            await _unitOfWork.ManagementService.UpdateAsync(id, management);
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Management>> PostManagement(Management management)
        {
            var createdManagement = await _unitOfWork.ManagementService.CreateAsync(management);
            //await _unitOfWork.SaveChangesAsync();
            return Ok(createdManagement);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteManagement(int id)
        {
            await _unitOfWork.ManagementService.DeleteAsync(id);
            return NoContent();
        }
    }
}
