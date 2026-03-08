using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioApi.Data;

namespace PortfolioApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProfileController : ControllerBase
{
    private readonly PortfolioContext _context;
    public ProfileController(PortfolioContext context) => _context = context;

    [HttpGet]
    public async Task<IActionResult> Get() => Ok(await _context.Profiles.FirstOrDefaultAsync());
}

[ApiController]
[Route("api/[controller]")]
public class ExperiencesController : ControllerBase
{
    private readonly PortfolioContext _context;
    public ExperiencesController(PortfolioContext context) => _context = context;

    [HttpGet]
    public async Task<IActionResult> Get() => Ok(await _context.Experiences.OrderBy(e => e.Order).ToListAsync());
}

[ApiController]
[Route("api/[controller]")]
public class EducationsController : ControllerBase
{
    private readonly PortfolioContext _context;
    public EducationsController(PortfolioContext context) => _context = context;

    [HttpGet]
    public async Task<IActionResult> Get() => Ok(await _context.Educations.OrderBy(e => e.Order).ToListAsync());
}

[ApiController]
[Route("api/[controller]")]
public class SkillsController : ControllerBase
{
    private readonly PortfolioContext _context;
    public SkillsController(PortfolioContext context) => _context = context;

    [HttpGet]
    public async Task<IActionResult> Get() => Ok(await _context.Skills.OrderBy(s => s.Category).ThenByDescending(s => s.Level).ToListAsync());

    [HttpGet("categories")]
    public async Task<IActionResult> GetCategories() =>
        Ok(await _context.Skills.Select(s => s.Category).Distinct().ToListAsync());
}

[ApiController]
[Route("api/[controller]")]
public class CertificationsController : ControllerBase
{
    private readonly PortfolioContext _context;
    public CertificationsController(PortfolioContext context) => _context = context;

    [HttpGet]
    public async Task<IActionResult> Get() => Ok(await _context.Certifications.ToListAsync());
}

[ApiController]
[Route("api/[controller]")]
public class LanguagesController : ControllerBase
{
    private readonly PortfolioContext _context;
    public LanguagesController(PortfolioContext context) => _context = context;

    [HttpGet]
    public async Task<IActionResult> Get() => Ok(await _context.Languages.OrderByDescending(l => l.Level).ToListAsync());
}

[ApiController]
[Route("api/[controller]")]
public class CommunityController : ControllerBase
{
    private readonly PortfolioContext _context;
    public CommunityController(PortfolioContext context) => _context = context;

    [HttpGet]
    public async Task<IActionResult> Get() => Ok(await _context.CommunityActivities.OrderBy(c => c.Order).ToListAsync());
}
