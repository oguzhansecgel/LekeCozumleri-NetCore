using AutoMapper;
using LekeCozumleri.BusinessLayer.Abstract;
using LekeCozumleri.DataAccessLayer.Context;
using LekeCozumleri.DtoLayer.Category;
using LekeCozumleri.DtoLayer.Stain;
using LekeCozumleri.Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LekeCozumleri.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StainController : ControllerBase
    {
        private readonly IStainService _stainService;
        private readonly IMapper _mapper;

        public StainController(IStainService stainService, IMapper mapper)
        {
            _stainService = stainService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            var values = _stainService.TGetListAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> getByIdStain(int id)
        {
            var values = _stainService.TGetByID(id);
            return Ok(values);
        }
        [HttpGet("StainWithCategoryName")]
        public async Task<IActionResult> stainWithCategoryName()
        {
            var context = new LekeContext();
            var values = context.Staines.Include(x => x.category).Select(y => new StainWithCategoryDto
            {
                CategoryName = y.category.CategoryName,
                StainDescription = y.StainDescription,
                StainId = y.StainId,
                StainName = y.StainName
            });
            return Ok(values);
        }
        [HttpGet("GetByLast5Stain")]
        public IActionResult GetByLast5Stain()
        {
            var values = _stainService.TGetByLast5Stain();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> createStain(CreateStainDto createStainDto)
        {
            var values = _mapper.Map<Stain>(createStainDto);
            _stainService.TAddAsync(values);
            return Ok("Kategori Başarıyla Eklendi");

        }
    }
}
