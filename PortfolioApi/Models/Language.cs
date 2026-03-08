namespace PortfolioApi.Models;

public class Language
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Level { get; set; } // 1-100
    public string Proficiency { get; set; } = string.Empty;
}
