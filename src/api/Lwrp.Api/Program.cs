using Lwrp.Application.Auth;
using Lwrp.LivewireClient;
using Lwrp.Contracts;
using Lwrp.Application.Device;

var builder = WebApplication.CreateBuilder(args);


const string AllowWebUi = "AllowWebUi";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: AllowWebUi, policy =>
    {
        policy
            .WithOrigins(
                "http://localhost:5212",   // example React dev server
                "https://localhost:5212",
                "http://localhost:5000",   // your Blazor UI origin
                "https://localhost:5000")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

// LWRP connection options from config
builder.Services.Configure<LwrpConnectionOptions>(
    builder.Configuration.GetSection("LwrpConnection"));


// Add services to the container.
builder.Services.AddControllers();

// Swagger & API explorer
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Bind Lwrp options
builder.Services.Configure<LwrpConnectionOptions>(
    builder.Configuration.GetSection("Lwrp"));

// Resilient connections with retries on fail.
builder.Services.AddSingleton<ILwrpConnection, ResilientLwrpConnection>();

// Register our login service
builder.Services.AddScoped<ILwrpLoginService, TcpLwrpLoginService>();

// Register device info service (VER, IP, SET)
builder.Services.AddScoped<ILwrpDeviceInfoService, TcpLwrpDeviceInfoService>();

var app = builder.Build();

app.UseHttpsRedirection();
// Order matters: use CORS before MapControllers
app.UseCors(AllowWebUi);

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
    app.UseSwagger();
    app.UseSwaggerUI();
// }

app.MapControllers();

app.Run();
