// Inheritance - child class gets everything from parent using colon (:)
public class Vehicle
{
    public string Brand { get; set; }
    public virtual void Start() => Console.WriteLine("Engine started");
}

public class Car : Vehicle
{
    public int Doors { get; set; }
    public override void Start() => Console.WriteLine($"{Brand} car started");
}


public abstract class BaseApiController : ControllerBase
{
    protected IActionResult Success<T>(T data) => Ok(new { success = true, data });
    protected IActionResult Error(string msg) => BadRequest(new { success = false, msg });
}

[ApiController]
[Route("api/[controller]")]
public class ProductsController : BaseApiController
{
    [HttpGet]
    public IActionResult Get() => Success(new { id = 1, name = "Laptop" });
}