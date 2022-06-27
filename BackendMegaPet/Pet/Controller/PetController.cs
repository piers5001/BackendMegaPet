﻿using AutoMapper;
using BackendMegaPet.Shared.Extensions;
using BackendMegaPet.Pet.Domain.Services;
using BackendMegaPet.Pet.Resources;
using Microsoft.AspNetCore.Mvc;
namespace BackendMegaPet.Pet.Controller;
using BackendMegaPet.Pet.Domain.Models;
[Route("api/v1/[controller]")]
public class PetController : ControllerBase
{
    private readonly IPetService _petService;
    private readonly IMapper _mapper;

    public PetController(IPetService petService, IMapper mapper)
    {
        _petService = petService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IEnumerable<PetResource>> GetAllAsync()
    {
        var pet = await _petService.ListAsync();
        var resources = _mapper.Map<IEnumerable<Pet>, IEnumerable<PetResource>>(pet);

        return resources;
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] SavePetResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var pet = _mapper.Map<SavePetResource, Pet>(resource);
        var result = await _petService.SaveAsync(pet);

        if (!result.Success)
            return BadRequest(result.Message);

        var petResource = _mapper.Map<Pet, PetResource>(result.Resource);
        
        return Ok(petResource);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync(int id, [FromBody] SavePetResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());
        
        var pet = _mapper.Map<SavePetResource, Pet>(resource);
        var result = await _petService.UpdateAsync(id,pet);
        
        if (!result.Success)
            return BadRequest(result.Message);
        

        var petResource = _mapper.Map<Pet, PetResource>(result.Resource);
        return Ok(petResource);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var result = await _petService.DeleteAsync(id);
        
        if (!result.Success)
            return BadRequest(result.Message);
        
        var petResource = _mapper.Map<Pet, PetResource>(result.Resource);
        
        return Ok(petResource);
    }
    
}