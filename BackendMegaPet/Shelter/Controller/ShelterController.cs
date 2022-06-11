using AutoMapper;
using BackendMegaPet.Shared.Extensions;
using BackendMegaPet.Shelter.Domain.Services;
using BackendMegaPet.Shelter.Resources;
using Microsoft.AspNetCore.Mvc;
namespace BackendMegaPet.Shelter.Controller;
using BackendMegaPet.Shelter.Domain.Models;
[Route("api/v1/[controller]")]
public class ShelterController : ControllerBase
{
    private readonly IShelterService _shelterService;
    private readonly IMapper _mapper;

    public ShelterController(IShelterService shelterService, IMapper mapper)
    {
        _shelterService = shelterService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IEnumerable<ShelterResource>> GetAllAsync()
    {
        var shelter = await _shelterService.ListAsync();
        var resources = _mapper.Map<IEnumerable<Shelter>, IEnumerable<ShelterResource>>(shelter);

        return resources;
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] SaveShelterResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var shelter = _mapper.Map<SaveShelterResource, Shelter>(resource);
        var result = await _shelterService.SaveAsync(shelter);

        if (!result.Success)
            return BadRequest(result.Message);

        var shelterResource = _mapper.Map<Shelter, ShelterResource>(result.Resource);
        
        return Ok(shelterResource);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync(int id, [FromBody] SaveShelterResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());
        
        var shelter = _mapper.Map<SaveShelterResource, Shelter>(resource);
        var result = await _shelterService.UpdateAsync(id,shelter);
        
        if (!result.Success)
            return BadRequest(result.Message);
        

        var shelterResource = _mapper.Map<Shelter, ShelterResource>(result.Resource);
        return Ok(shelterResource);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var result = await _shelterService.DeleteAsync(id);
        
        if (!result.Success)
            return BadRequest(result.Message);
        
        var shelterResource = _mapper.Map<Shelter, ShelterResource>(result.Resource);
        
        return Ok(shelterResource);
    }
    
}














