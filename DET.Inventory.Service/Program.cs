var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Configuraci�n de servicios para la aplicaci�n
builder.Services.AddSingleton<IConfiguration>(builder.Configuration);
builder.Services.AddSingleton<DET.Inventory.DataAccess.Interfaces.IConnectionManager, DET.Inventory.DataAccess.ConnectionManager>();
builder.Services.AddSingleton<DET.Inventory.DataAccess.Interfaces.IProductos, DET.Inventory.DataAccess.Productos >();
builder.Services.AddSingleton<DET.Inventory.BusinessLogic.Interfaces.IProductos, DET.Inventory.BusinessLogic.Productos>();

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
