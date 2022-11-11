using BootcampAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootcampAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly DBFullStackContext _dbContext;
        //public ProductController(DBFullStackContext dbContext) => _dbContext = dbContext; /* DI */
        public ProductController() => _dbContext = new DBFullStackContext(); 

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> Get()
        {
            if (_dbContext.Products == null)
                return NotFound();
            return await _dbContext.Products.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> Get(int id)
        {
            var result = _dbContext.Products.Any(x => x.ProductId == 3);
            var ress = (_dbContext.Products?.Any(e => e.ProductId != id)).GetValueOrDefault();
            if (_dbContext.Products == null || ress)
                return NotFound();
            return await _dbContext.Products.FindAsync(id);
        }

        [HttpPost]
        public async Task<ActionResult<Product>> Post(Product Product)
        {
            _dbContext.Products.Add(Product);
            await _dbContext.SaveChangesAsync();
            return Ok("Başarıyla eklendi.");
        }

        [HttpPut("{id}")] /* DTO */
        public async Task<ActionResult> Put(int id, Product Product)
        {
            if (id != Product.ProductId)
                return BadRequest();

            _dbContext.Entry(Product).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException)
            {
                if (!ProductExxits(id))
                    return NotFound();
                else
                    throw;
            }
            return NoContent();
        }

        private bool ProductExxits(long id)
        {
            return (_dbContext.Products?.Any(e => e.ProductId == id)).GetValueOrDefault();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            if (_dbContext.Products == null)
                return NotFound();

            var findProduct = await _dbContext.Products.FindAsync(id);
            if (findProduct == null)
                return NotFound();  

            _dbContext.Products.Remove(findProduct);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }

    }
}
