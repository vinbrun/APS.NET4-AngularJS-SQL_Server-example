using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

public class ProductsController : ApiController
{
    private readonly DataContext _context = new DataContext();

    [HttpGet]
    public IEnumerable<Product> Get()
    {
        return _context.Products.ToList();
    }

    [HttpPost]
    public IHttpActionResult Post(Product product)
    {
        if (product == null) return BadRequest();

        _context.Products.Add(product);
        _context.SaveChanges();

        return Ok(product);
    }

    [HttpPut]
    public IHttpActionResult Put(Product product)
    {
        var existingProduct = _context.Products.Find(product.Id);
        if (existingProduct == null) return NotFound();

        existingProduct.Name = product.Name;
        existingProduct.Price = product.Price;
        existingProduct.Stock = product.Stock;

        _context.SaveChanges();

        return Ok(existingProduct);
    }

    [HttpDelete]
    public IHttpActionResult Delete(int id)
    {
        var product = _context.Products.Find(id);
        if (product == null) return NotFound();

        _context.Products.Remove(product);
        _context.SaveChanges();

        return Ok();
    }
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
}
