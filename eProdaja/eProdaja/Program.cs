using eProdaja.Database;
using eProdaja.eProdaja.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IKorisnikService, KorisnikService>();
builder.Services.AddScoped<IJedinicaMjereServices, JedinicaMjereServices>();
builder.Services.AddScoped<IVrsteProizvodaService, VrsteProizvodaService>();
builder.Services.AddScoped<IProizvodService, ProizvodService>();
builder.Services.AddDbContext<EProdajaContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")
    ));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();