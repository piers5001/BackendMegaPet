namespace BackendMegaPet.User.Resources;

public class SaveUserResource
{
    public string name { get; set; }
    public string lastName { get; set; }
    public long phone { get; set; }
    public string email { get; set; }
    public string image { get; set; }
    public string password { get; set; }
    public int birthday { get; set; }
}