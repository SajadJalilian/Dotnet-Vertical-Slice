using Blog.Api.Extensions.DependencyInjections;
using Blog.Api.Extensions.Middlewares;

#region AddServices

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddServices();
builder.Services.AddConfiguredDatabase(builder.Configuration);

#endregion

#region Pipeline

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseConfiguredMigration();

app.Run();

#endregion