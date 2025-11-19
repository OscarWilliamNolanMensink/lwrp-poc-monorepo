using Lwrp.Application.Auth;
using Lwrp.LivewireClient;
using Lwrp.Contracts;
using Lwrp.Application.Device;

var builder = WebApplication.CreateBuilder(args);

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

// Register our login service
builder.Services.AddScoped<ILwrpLoginService, TcpLwrpLoginService>();

// Register device info service (VER, IP, SET)
builder.Services.AddScoped<ILwrpDeviceInfoService, TcpLwrpDeviceInfoService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
    app.UseSwagger();
    app.UseSwaggerUI();
// }

app.MapControllers();

app.Run();
