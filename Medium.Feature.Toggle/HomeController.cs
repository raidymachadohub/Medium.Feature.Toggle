using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement;

namespace Medium.Feature.Toggle;

[Route("[controller]")]
public class HomeController : Controller
{
    private readonly IFeatureManager _featureManager;
    private readonly CustomContext _customContext;

    public HomeController(IFeatureManager featureManager)
    {
        _featureManager = featureManager;
        _customContext = new CustomContext();
    }
    
    [HttpGet]
    public async Task<ActionResult> Get()
    {
        _customContext.NameNewFeature = "New_Function";
        var isActive = await _featureManager.IsEnabledAsync("Custom", _customContext);
        return Ok(isActive);
    }
}