using Microsoft.FeatureManagement;

namespace Medium.Feature.Toggle;

[FilterAlias("Custom")]
public class CustomFilter : IContextualFeatureFilter<CustomContext>
{
    public Task<bool> EvaluateAsync(FeatureFilterEvaluationContext featureFilterContext, CustomContext appContext)
    {
        var isEnabled = appContext.NameNewFeature == "New_Function"; // For example you can create a connect with database and do any stuff.
        return Task.FromResult(isEnabled);
    }
}