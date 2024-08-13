using EMemoryBook.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EMemoryBook.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController<T> : ControllerBase where T : class
    {
        private readonly BaseRepository<T> _repository;

        public BaseController(BaseRepository<T> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var entities = await _repository.GetAllAsync();
            return Ok(entities);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null)
            {
                return NotFound();
            }
            return Ok(entity);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] T entity)
        {
            if (entity == null)
            {
                return BadRequest();
            }

            await _repository.AddAsync(entity);
            return CreatedAtAction(nameof(GetById), new { id = entity.GetType().GetProperty("Id").GetValue(entity) }, entity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] T entity)
        {
            if (entity == null || !id.Equals(entity.GetType().GetProperty("Id").GetValue(entity)))
            {
                return BadRequest();
            }

            await _repository.UpdateAsync(entity);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var existingEntity = await _repository.GetByIdAsync(id);
            if (existingEntity == null)
            {
                return NotFound();
            }

            await _repository.DeleteAsync(id);
            return NoContent();
        }
    }
}
