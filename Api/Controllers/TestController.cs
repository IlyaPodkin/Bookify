using Microsoft.AspNetCore.Mvc;

public class TestController : BaseController
{
    protected readonly DataService db;

    public TestController(DataService db)
    {
        this.db = db;
    }

    [HttpPost("booking")]
    public IActionResult CreateWorker([FromBody] Worker worker)
    {
        Worker result = db.Create(worker);
        if (worker == null)
        {
            return BadRequest("Сотрудники не найдены");
        }
        return Ok(worker);
    }

    [HttpGet("booking")]
    public ActionResult<List<Worker>> GetWorker()
    {
        return Ok(db.GetData());
    }

    [HttpPut("booking/{id}")]
    public IActionResult UpdateWorker([FromBody]WorkerDto workerDto, Guid id)
    {
        bool result = db.Update(workerDto, id);
        if (result == false)
        {
            return BadRequest("Сотрудник с указаным id не найден");
        }
        return Ok();
    }

    [HttpDelete("booking/{id}")]
    public IActionResult DeleteWorker(Guid id)
    {
        bool result = db.Delete(id);
        if (result == false)
        {
            return BadRequest("Сотрудник с указаным id не найден");
        }
        return Ok();
    }
}
