using System.ComponentModel.DataAnnotations;

namespace BackendMegaPet.Shelter.Resources;

public class SaveShelterResource
{
    [Required]
    [MaxLength(10)]
    public String address { get; set; }
    [Required]
    [MaxLength(120)]
    public String image { get; set; }
    [Required]
    [MaxLength(10)]
    public int phone { get; set; }
    [Required]
    [MaxLength(100)]
    public String district { get; set; }
    [Required]
    [MaxLength(100)]
    public String location { get; set; }
}