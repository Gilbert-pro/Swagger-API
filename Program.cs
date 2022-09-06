using APIDemo.Startup;


var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterServices();

var app = builder.Build();

app.ConfigureSwagger();

app.UseHttpsRedirection();

app.MapUserEndpoints();
app.MapDogEndpoints();



app.Run();
