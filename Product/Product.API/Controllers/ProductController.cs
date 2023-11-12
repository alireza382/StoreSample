using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Products.Domain.Entities;
using Products.Infra.Repository.Repository;
using System.Net;

namespace Products.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _repository;


        public ProductController(IProductRepository productRepository)
        {
                _repository = productRepository?? throw new ArgumentNullException();
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Product>),(int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<Product>>> Getproducts()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id:length(24)}", Name = "GetProduct")]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(Product), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<Product>> GetProductById(string id)
        {
            throw new NotImplementedException();
        }

        [Route("[action]/{category}", Name = "GetProductByCategory")]
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Product>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<Product>>> GetProductByCategory(string categoryName)
        {
            throw new NotImplementedException();
        }

  
    }
}
