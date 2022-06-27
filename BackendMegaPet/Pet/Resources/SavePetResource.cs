using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendMegaPet.Pet.Resources;

public class SavePetResource
{
    [Required]
    public int Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string name { get; set; }
    [MaxLength(150)]
    public string description { get; set; }
    [Required]
    [MaxLength(50)]
    public string image { get; set; }
    [Required]
    public int rescuedTime { get; set; }
    [Required]
    [MaxLength(50)]
    public string category { get; set; }
    [Required]
    [MaxLength(50)]
    public string inventoryStatus { get; set; }
    [Required]
    public int rating { get; set; }
}