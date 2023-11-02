using WebCamp.Configuration.Profiles;
using WebCamp.Data;
using WebCamp.Data.Repositories;
using WebCamp.Data.Repositories.Interfaces;
using WebCamp.Domain.Services;
using WebCamp.Domain.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSqlServer<WebCampContext>(builder.Configuration["ConnectionString:Local"]);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(DomainToViewModelProfile));
builder.Services.AddAutoMapper(typeof(ViewModelToDomainProfile));

builder.Services.AddScoped<ICampeonatoService, CampeonatoService>();

builder.Services.AddScoped<ICampeonatoRepository, CampeonatoRepository>();

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
