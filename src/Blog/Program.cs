using Blog.Common.Api.Extensions.DependencyInjections;
using Blog.Common.Api.Extensions.Middlewares;
using Blog.Modules.Post;

#region AddServices

var builder = WebApplication.CreateBuilder(args);

builder.Host.ConfigureAppSettings();

builder.Services.AddConfiguredDatabase(builder.Configuration);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
builder.Services.AddPostServices();

#endregion

#region Pipeline

var app = builder.Build();

app.UseRouting();

var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
if (environment is "Local" or "Development" or "NewFeature" or "Staging")
{
    app.UseSwagger();
    app.UseSwaggerUI(options => options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1"));
}

app.MapControllers();
app.UseConfiguredMigration();
app.RegisterPostApis();

app.Run();

#endregion