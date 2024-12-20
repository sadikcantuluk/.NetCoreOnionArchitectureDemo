using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Application.Dto;
using ProductApp.Application.Interface.Repository;

namespace ProductApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepositoryAsync _productRepositoryAsync;

        public ProductController(IProductRepositoryAsync productRepositoryAsync)
        {
            _productRepositoryAsync = productRepositoryAsync;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var allList = await _productRepositoryAsync.GetAllAsync();
            var dtoList = allList.Select(x => new ProductViewDto
            {
                Id = x.Id,
                Name = x.Name,
            });

            return Ok(dtoList);
        }
    }
}
