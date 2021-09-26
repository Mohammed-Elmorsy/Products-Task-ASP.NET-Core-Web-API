using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductsTaskWebAPI_MohammedElmorsy.Models;
using ProductsTaskWebAPI_MohammedElmorsy.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductsTaskWebAPI_MohammedElmorsy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        ProductRepository productRepository;

        public ProductsController(ProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(productRepository.GetAll());
        }

        [HttpPut]
        public IActionResult Update(Product product)
        {
            if (ModelState.IsValid)
            {
                return Ok(productRepository.Update(product));
            }
            return BadRequest(product);
        }
    }
}
