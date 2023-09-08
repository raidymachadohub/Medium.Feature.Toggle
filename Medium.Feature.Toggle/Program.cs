using Medium.Feature.Toggle;
using Microsoft.FeatureManagement;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddFeatureManagement().AddFeatureFilter<CustomFilter>();

var app = builder.Build();

app.MapControllers();

app.Run();