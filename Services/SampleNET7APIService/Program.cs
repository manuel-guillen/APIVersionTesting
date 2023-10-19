using Asp.Versioning;

// ==========================================================
// Create builder and add services to the container
// ==========================================================
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApiVersioning(options =>
{
    options.ApiVersionReader = new QueryStringApiVersionReader("api-version");
    options.AssumeDefaultVersionWhenUnspecified = false;
    options.ReportApiVersions = true;
}).AddMvc();

builder.Services.AddControllers();

// ==========================================================
// Build application and configure the HTTP request pipeline.
// ==========================================================
var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
