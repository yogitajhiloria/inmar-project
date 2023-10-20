using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<ProductController> _logger;
    private readonly IOfferService _offerService;

    public ProductController(ILogger<ProductController> logger,IOfferService offerService)
    {
        _logger = logger;
        _offerService = offerService;
    }

    [HttpGet(Name = "GetTodaysOffers")]
    public async Task<IEnumerable<Offer>> GetTodaysOffers()
    {
        var result = await new Task<IEnumerable<Offer>>(()=>this._offerService.GetTodaysOffers());
        return result;
    }

    [HttpGet(Name = "Get3LowProducts")]
    public async Task<IEnumerable<Product>> Get3LowProducts()
    {
        var result = await new Task<IEnumerable<Product>>(()=>this._offerService.GetAllProducts().OrderBy(x=>x.Price).Take(3));
        
        return result;
    }
    [HttpGet(Name = "Get2LowProducts")]
    public async Task<IEnumerable<Product>> Get2LowProducts()
    {
        var result = await new Task<IEnumerable<Product>>(()=>this._offerService.GetAllProducts().OrderBy(x=>x.Price).Take(2));
        
        return result;
    }

    [HttpPost(Name = "AddProduct")]
    public bool AddProduct(Product product)
    {
        return this._offerService.AddProduct(product);
    }
}

