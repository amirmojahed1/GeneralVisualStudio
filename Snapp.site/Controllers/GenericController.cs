using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[Route("api/[controller]")]
[ApiController]
public class GenericController<T> : ControllerBase where T : class
{
    private readonly IRepository<T> _repository;

    public GenericController(IRepository<T> repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public ActionResult<IEnumerable<T>> GetAll()
    {
        return Ok(_repository.GetAll());
    }

    [HttpGet("{id}")]
    public ActionResult<T> GetById(int id)
    {
        var entity = _repository.GetById(id);
        if (entity == null) return NotFound();
        return Ok(entity);
    }

    [HttpPost]
    public ActionResult Insert([FromBody] T entity)
    {
        if (_repository.Insert(entity))
        {
            _repository.Save();
            return CreatedAtAction(nameof(GetById), new { id = entity }, entity);
        }
        return BadRequest();
    }

    [HttpPut]
    public ActionResult Update([FromBody] T entity)
    {
        if (_repository.Update(entity))
        {
            _repository.Save();
            return NoContent();
        }
        return BadRequest();
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        if (_repository.Delete(id))
        {
            _repository.Save();
            return NoContent();
        }
        return NotFound();
    }
}
