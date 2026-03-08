namespace PortfolioApi.Models;

public class Skill
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public int Level { get; set; } // 1-100
    public string Icon { get; set; } = string.Empty;
}
