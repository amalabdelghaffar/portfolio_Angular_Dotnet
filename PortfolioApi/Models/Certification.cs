namespace PortfolioApi.Models;

public class Certification
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Issuer { get; set; } = string.Empty;
    public string Date { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
