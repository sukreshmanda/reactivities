using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
public abstract class BaseCrudController<T> : BaseController
{
    [HttpGet]
    public abstract IEnumerable<T> GetAll();
    [HttpGet("{id}")]
    public abstract T Get([FromRoute] Guid id);
}