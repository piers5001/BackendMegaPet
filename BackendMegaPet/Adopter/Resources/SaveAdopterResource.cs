using System.ComponentModel.DataAnnotations;

namespace BackendMegaPet.Adopter.Resources;

public class SaveAdopterResource
{
    [Required]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(10)]
    public string name { get; set; }
    
    [Required]
    [MaxLength(10)]
    public string lastName { get; set; }
    
    [Required]
    public string gender { get; set; }
    
    [Required]
    public string age { get; set; }
    
    [Required]
    public string status { get; set; }

    [Required]
    public string description { get; set; }
}