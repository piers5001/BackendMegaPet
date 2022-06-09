using System.ComponentModel.DataAnnotations;

namespace BackendMegaPet.User.Resources;

public class SaveUserResource
{
    [Required]
    [MaxLength(10)]
    public string name { get; set; }
    
    [Required]
    [MaxLength(10)]
    public string lastName { get; set; }
    
    [Required]
    [MaxLength(10)]
    public long phone { get; set; }
    
    [Required]
    [MaxLength(20)]
    public string email { get; set; }
    
    [Required]
    [MaxLength(50)]
    public string image { get; set; }
    
    [Required]
    [MaxLength(15)]
    public string password { get; set; }
    
    [Required]
    [MaxLength(10)]
    public int birthday { get; set; }
}