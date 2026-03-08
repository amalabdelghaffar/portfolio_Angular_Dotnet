namespace PortfolioApi.Models;

public class CommunityActivity
{
    public int Id { get; set; }
    public string Role { get; set; } = string.Empty;
    public string Organization { get; set; } = string.Empty;
    public string StartDate { get; set; } = string.Empty;
    public string EndDate { get; set; } = string.Empty;
    public int Order { get; set; }
}
