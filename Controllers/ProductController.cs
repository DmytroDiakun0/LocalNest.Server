using LocalNest.Server.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LocalNest.Server.Controllers
{
    [ApiController]
    [Route("/product")]
    public class ProductController : ControllerBase
    {
        LocalNestDbContext _dbContext;

        public ProductController(LocalNestDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var products = await _dbContext.Products
                                    .Select(p => new
                                    {
                                        p.Id,
                                        p.Name,
                                        p.Description,
                                        p.Image_URL,
                                        p.Price,
                                        p.stock,
                                        p.CreatedAt,
                                        p.UpdatedAt
                                    })
                                    .ToListAsync();

                                        return Ok(products);
                                    }
    }
}
