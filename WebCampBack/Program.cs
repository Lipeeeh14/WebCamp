using Microsoft.Extensions.Options;
using WebCampBack.Endpoints;
using WebCampBack.Integration.Configuration;
using WebCampBack.Integration.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddOptions<SimuladorSettings>();

builder.Services.AddHttpClient<SimuladorService>((serviceProvider, httpClient) => 
{
	//var simuladorSettings = serviceProvider.GetRequiredService<IOptions<SimuladorSettings>>().Value;

	httpClient.BaseAddress = new Uri("http://localhost:5000");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapTimeEndpoints();

app.Run();

