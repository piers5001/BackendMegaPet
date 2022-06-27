using BackendMegaPet.Shared.Domain.Repositories;
using BackendMegaPet.Pet.Domain.Repositories;
using BackendMegaPet.Pet.Domain.Services;
using BackendMegaPet.Pet.Domain.Services.Communication;
namespace BackendMegaPet.Pet.Services;
using BackendMegaPet.Pet.Domain.Models;


public class PetService : IPetService
{
    private readonly IPetRepository _petRepository;
    private readonly IUnitOfWork _unitOfWork;

    public PetService(IUnitOfWork unitOfWork,IPetRepository petRepository)
    {
        _unitOfWork = unitOfWork;
        _petRepository = petRepository;
    }

    public async Task<IEnumerable<Pet>> ListAsync()
    {
        return await _petRepository.ListAsync();
    }

    public async Task<PetResponse> SaveAsync(Pet pet)
    {
        try
        {
            await _petRepository.AddAsync(pet);
            await _unitOfWork.CompleteAsync();

            return new PetResponse(pet);
        }
        catch (Exception e)
        {
            return new PetResponse($"An Error occurred while saving the pet: {e.Message}");
        }
    }

    public async Task<PetResponse> UpdateAsync(int id, Pet pet)
    {
        var existingPet = await _petRepository.FindPetByIdAsync(id);
            
        if (existingPet == null)
        {
            return new PetResponse("Pet not found please re check the pet id");
        }

        try
        {
            _petRepository.UpdatePet(existingPet);
            await _unitOfWork.CompleteAsync();

            return new PetResponse(existingPet);
        }
        catch (Exception e)
        { 
            return new PetResponse($"An Error occurred while Updating the pet: {e.Message}");
        }
        
    }

    public async Task<PetResponse> DeleteAsync(int id)
    {
        var existingPet = await _petRepository.FindPetByIdAsync(id);
        if (existingPet == null)
        {
            return new PetResponse("User not Found");
        }

        try
        {
            _petRepository.RemovePet(existingPet);
            await _unitOfWork.CompleteAsync();

            return new PetResponse(existingPet);
        }
        catch (Exception e)
        {
            return new PetResponse($"An Error occurred while deleting the pet: {e.Message}");
        }
    }
}