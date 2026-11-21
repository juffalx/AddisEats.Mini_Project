using AddisEats.Services.MenuService;
using AddisEats.Models;
using AddisEats.Services.Clock;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IMenuService, MenuService>();
builder.Services.AddScoped<IClock, Clock>();
builder.Services.AddScoped<IClock, Clock>();
// builder.Services.AddTransient<IClock, Clock>();
// builder.Service<IClock, Clock>();

builder.Services.Configure<MenuOptions>(
    builder.Configuration.GetSection("MenuOptions"));

builder.Services.AddCors(o => o.AddPolicy("frontend", p =>
p.WithOrigins("http://localhost:5173") // Vite
.AllowAnyHeader().AllowAnyMethod()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("frontend");
app.UseHttpsRedirection();
app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
