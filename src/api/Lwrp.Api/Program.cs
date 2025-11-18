using Lwrp.Application.Auth;
using Lwrp.LivewireClient;

var builder = WebApplication.CreateBuilder(args);

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

var app = builder.Build();

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
    app.UseSwagger();
    app.UseSwaggerUI();
// }

app.MapControllers();

app.Run();
