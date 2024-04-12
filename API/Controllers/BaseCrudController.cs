using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
public abstract class BaseCrudController<T> : BaseController
{
    public abstract Task<ActionResult<IEnumerable<T>>> GetAll();
    public abstract Task<ActionResult<T>> Get([FromRoute] Guid id);
}