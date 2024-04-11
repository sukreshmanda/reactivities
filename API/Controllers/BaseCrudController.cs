using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
public abstract class BaseCrudController<T> : BaseController
{
    [HttpGet]
    public abstract ActionResult<IEnumerable<T>> GetAll();
    [HttpGet("{id}")]
    public abstract Task<ActionResult<T>> Get([FromRoute] Guid id);
}