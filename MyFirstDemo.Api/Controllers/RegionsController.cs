using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFirstDemo.Api.CustomActionFilters;
using MyFirstDemo.Api.Data;
using MyFirstDemo.Api.Models.Domain;
using MyFirstDemo.Api.Models.Dto;
using MyFirstDemo.Api.Models.RegionDto;
using MyFirstDemo.Api.Repositories;

namespace MyFirstDemo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly NZWalksDbContext dbContext;
        private readonly IRegionRepository regionRepository;
        private readonly IMapper mapper;
        public RegionsController(NZWalksDbContext dbContext,IRegionRepository regionRepository,IMapper mapper)
        {
            this.dbContext = dbContext;
            this.regionRepository = regionRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            //Get data from database
            var regions =await regionRepository.GetAllAsync();

            //Return DTOs
            return Ok(mapper.Map<List<RegionDto>>(regions));
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id) {
            //var region= dbContext.Regions.Find(id);
            var region =await regionRepository.GetByIdAsync(id);
            if(region == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<RegionDto>(region));  
        }

        [HttpPost]
        [ValidateModel]
        public async Task< IActionResult> Create([FromBody] AddRegionRequestDto addRegionRequestDto) {
          
                //Map or convert DTO to Domain main
                var regionDomainModel = mapper.Map<Region>(addRegionRequestDto);


                //Use Domain Model to create Region
                regionDomainModel = await regionRepository.CreateAsync(regionDomainModel);


                //map domain model back to Dto
                var regionDto = mapper.Map<RegionDto>(regionDomainModel);
                return CreatedAtAction(nameof(GetById), new { id = regionDomainModel.Id }, regionDto);
           
        }

        [HttpPut]
        [Route("{id:Guid}")]
        [ValidateModel]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateRegionRequestDto updateRegionRequestDto)
        {

            //var region = dbContext.Regions.Find(id);
            //Map Dto to Domain model
            var regionDomainModel = mapper.Map<Region>(updateRegionRequestDto);

            //Check if region exists
            regionDomainModel = await regionRepository.UpdateAsync(id, regionDomainModel);
            if (regionDomainModel == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<RegionDto>(regionDomainModel));
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            //var region = dbContext.Regions.Find(id);
            var regionDomainModel=await regionRepository.DeleteAsync(id);
            if (regionDomainModel == null)
            {
                return NotFound();
            }
            
            return Ok(mapper.Map<RegionDto>(regionDomainModel));
        }
    }
}
