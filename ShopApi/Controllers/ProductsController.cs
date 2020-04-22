using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ShopApi.Models;

namespace ShopApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ShopDBContext _context;

        public ProductsController(ShopDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Get()
        {
            return Ok(_context.Product.AsNoTracking().ToListAsync());
        }

        [Route("{id:int}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            var product = await _context.Product.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            if (product == null)
                return NotFound();
            else
                return Ok(product);
        }

        //afficher pour chaque client le m total de leur achat

        [HttpGet]
        [Route("totalachat")]
        public async Task<IActionResult> GetTotalAchat() 
        {
            //var result = (
            //    from ot in _context.OrderItem
            //    join o in _context.Order on ot.OrderId equals o.Id
            //    join c in _context.Customer on o.CustomerId equals c.Id
            //    group c.Order by  
            //    select new { }
            //);

            //_context.Customer.Include(x => x.Order).ThenInclude(x=>x.).SelectMany(x => x.Order.).Sum();

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Product product) 
        {
            if (ModelState.IsValid)
            {
                if (product.Id != 0)
                {
                    var productToEdit = await _context.Product.SingleOrDefaultAsync(x => x.Id == product.Id);
                    if (productToEdit == null)
                        return NotFound();

                    else
                    {
                        productToEdit.Name = product.Name;
                        productToEdit.Price = product.Price;
                        productToEdit.Stock = product.Stock;
                        productToEdit.CreationDate = product.CreationDate;
                        productToEdit.UpdateDate = product.UpdateDate;
                        await _context.SaveChangesAsync();
                        return Ok(productToEdit);
                    }
                }
                else
                {
                    await _context.Product.AddAsync(product);
                    await _context.SaveChangesAsync();
                    return Created($"{product.Id}", product);
                }
            }
            else
                return BadRequest();
        }
    }
}
