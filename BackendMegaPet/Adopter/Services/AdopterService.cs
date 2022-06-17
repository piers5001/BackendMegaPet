using BackendMegaPet.Adopter.Domain.Repositories;
using BackendMegaPet.Shared.Domain.Repositories;
using BackendMegaPet.Adopter.Domain.Services;
using BackendMegaPet.Adopter.Domain.Services.Communication;
namespace BackendMegaPet.Adopter.Services;
using BackendMegaPet.Adopter.Domain.Models;

public class AdopterService : IAdopterService
{
    private readonly IAdopterRepository _adopterRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AdopterService(IUnitOfWork unitOfWork, IAdopterRepository adopterRepository)
    {
        _unitOfWork = unitOfWork;
        _adopterRepository = adopterRepository;
    }

    public async Task<IEnumerable<Adopter>> ListAsync()
    {
        return await _adopterRepository.ListAsync();
    }

    public async Task<AdopterResponse> SaveAsync(Adopter adopter)
    {
        try
        {
            await _adopterRepository.AddAsync(adopter);
            await _unitOfWork.CompleteAsync();

            return new AdopterResponse(adopter);
        }
        catch (Exception e)
        {
            return new AdopterResponse($"An error occurred while saving the Adopter: {e.Message}");
        }
    }

    public async Task<AdopterResponse> UpdateAsync(int id, Adopter adopter)
    {
        var existingAdopter = await _adopterRepository.FindByIdAsync(id);

        if (existingAdopter == null)
            return new AdopterResponse("Adopter not found");

        // existingAdopter.name = Adopter.name;

        try
        {
            _adopterRepository.Update(existingAdopter);
            await _unitOfWork.CompleteAsync();

            return new AdopterResponse(existingAdopter);
        }
        catch (Exception e)
        {
            return new AdopterResponse($"An error occurred while updating the Adopter: {e.Message}");

        }
    }

    public async Task<AdopterResponse> DeleteAsync(int id)
    {
        var existingAdopter = await _adopterRepository.FindByIdAsync(id);

        if (existingAdopter == null)
            return new AdopterResponse("Category not found");

        try
        {
            _adopterRepository.Remove(existingAdopter);
            await _unitOfWork.CompleteAsync();

            return new AdopterResponse(existingAdopter);
        }
        catch (Exception e)
        {
            return new AdopterResponse($"An error occurred while deleting the Adopter: {e.Message}");

        }
    }
}
