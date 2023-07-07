namespace BackyardGleanersApi.Models
{
  public class Host 
  {
    public int HostId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; } 
    public string Food { get; set; }
    public string Availability {get; set; }
    public string Location { get; set; }
    public string Contact { get; set; }
  }
}