using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Api.Dtos;
using WebApplication1.Api.Services;

namespace WebApplication1.Api.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        [HttpGet("all")]
        public JsonResult GetProducts()
        {
            return new JsonResult(ProductService.Current.Products);
        }
        [Route("{id}")]
        public JsonResult GetProduct(int id)
        {
            return new JsonResult(ProductService.Current.Products.SingleOrDefault(x => x.Id == id));
        }
    }
}
