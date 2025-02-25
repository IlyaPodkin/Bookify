using Api.Data.DataServices;
using Api.Data.SettingsDb;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationContext>(opt => opt.UseNpgsql(
    builder.Configuration.GetConnectionString("DefaultConnection")));

//CORS
builder.Services.AddCors(opt =>
{
    opt.AddPolicy("CorsPolicy", policy => policy.WithOrigins("http://localhost:3000")
    .AllowAnyHeader()
    .AllowAnyMethod());
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMvc();
builder.Services.AddControllers();
builder.Services.AddScoped<UserService>();
var app = builder.Build();

//CORS
app.UseCors("CorsPolicy");
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();  
    app.UseSwaggerUI();  
}

app.MapControllers();
app.Run();
