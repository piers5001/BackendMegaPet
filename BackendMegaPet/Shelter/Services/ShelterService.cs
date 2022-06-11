using BackendMegaPet.Shelter.Domain.Repositories;
using BackendMegaPet.Shelter.Domain.Services;
using BackendMegaPet.Shelter.Domain.Services.Communication;

namespace BackendMegaPet.Shelter.Services;

public class ShelterService : IShelterService
{
    private readonly IShelterRepository _shelterRepository;
    private readonly IUnitOfWork _unitOfWork;

    public ShelterService(IShelterRepository shelterRepository, IUnitOfWork unitOfWork)
    {
        _shelterRepository = shelterRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<Domain.Models.Shelter>> ListAsync()
    {
        return await _shelterRepository.ListAsync();
    }

    public async Task<ShelterResponse> SaveAsync(Domain.Models.Shelter shelter)
    {
        try
        {
            await _shelterRepository.AddAsync(shelter);
            await _unitOfWork.CompleteAsync();

            return new ShelterResponse(shelter);
        }
        catch (Exception e)
        {
            return new ShelterResponse($"An Error occurred while saving the shelter: {e.Message}");
        }
    }

    public async Task<ShelterResponse> UpdateAsync(int id, Domain.Models.Shelter shelter)
    {
        var existingShelter = await _shelterRepository.FindShelterByIdAsync(id);
        
        if (existingShelter == null)
        {
            return new ShelterResponse("Shelter not found please re check the Shelter id");
        }

        try
        {
            _shelterRepository.UpdateShelter(existingShelter);
            await _unitOfWork.CompleteAsync();

            return new ShelterResponse(existingShelter);
        }
        catch (Exception e)
        { 
            return new ShelterResponse($"An Error occurred while Updating the shelter: {e.Message}");
        }
        
    }

    public async Task<ShelterResponse> DeleteAsync(int id)
    {
        var existingShelter = await _shelterRepository.FindShelterByIdAsync(id);
        if (existingShelter == null)
        {
            return new ShelterResponse("User not Found");
        }

        try
        {
            _shelterRepository.RemoveShelter(existingShelter);
            await _unitOfWork.CompleteAsync();

            return new ShelterResponse(existingShelter);
        }
        catch (Exception e)
        {
            return new ShelterResponse($"An Error occurred while deleting the shelter: {e.Message}");
        }
    }
}