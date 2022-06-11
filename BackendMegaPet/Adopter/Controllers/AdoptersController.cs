using AutoMapper;
using BackendMegaPet.Shared.Extensions;
using BackendMegaPet.Adopter.Domain.Services;
using BackendMegaPet.Adopter.Domain.Services.Communication;
using BackendMegaPet.Adopter.Resources;
using Microsoft.AspNetCore.Mvc;

namespace BackendMegaPet.Adopter.Controller;

using BackendMegaPet.Adopter.Domain.Models;
[Route("api/v1/[controller]")]
public class AdoptersController : ControllerBase
{
    private readonly IAdopterService _adopterService;
    private readonly IMapper _mapper;

    public AdoptersController(IAdopterService adopterService, IMapper mapper)
    {
        _adopterService = adopterService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IEnumerable<AdopterResource>> GetAllAsync()
    {
        var adopters = await _adopterService.ListAsync();
        var resources = _mapper.Map<IEnumerable<Adopter>, IEnumerable<AdopterResource>>(adopters);

        return resources;
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] SaveAdopterResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var adopter = _mapper.Map<SaveAdopterResource, Adopter>(resource);
        var result = await _adopterService.SaveAsync(adopter);

        if (!result.Success)
            return BadRequest(result.Message);

        var adopterResource = _mapper.Map<Adopter, AdopterResource>(result.Resource);

        return Ok(adopterResource);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync(int id, [FromBody] SaveAdopterResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var adopter = _mapper.Map<SaveAdopterResource, Adopter>(resource);
        var result = await _adopterService.UpdateAsync(id, adopter);

        if (!result.Success)
            return BadRequest(result.Message);

        var adopterResource = _mapper.Map<Adopter, AdopterResource>(result.Resource);

        return Ok(adopterResource);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var result = await _adopterService.DeleteAsync(id);

        if (!result.Success)
            return BadRequest(result.Message);

        var adopterResource = _mapper.Map<Adopter, AdopterResource>(result.Resource);

        return Ok(adopterResource);
    }
}
