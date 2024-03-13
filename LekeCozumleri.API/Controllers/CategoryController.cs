using AutoMapper;
using LekeCozumleri.BusinessLayer.Abstract;
using LekeCozumleri.DtoLayer.Category;
using LekeCozumleri.Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LekeCozumleri.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> getAll()
        {
           var values = _categoryService.TGetListAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> getByIdCategory(int id)
        {
            var values = _categoryService.TGetByID(id);
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> createCategory(CreateCategoryDto createCategoryDto)
        {
            var values = _mapper.Map<Category>(createCategoryDto);
            _categoryService.TAddAsync(values);
            return Ok("Kategori Başarıyla Eklendi");

        }

    }
}
