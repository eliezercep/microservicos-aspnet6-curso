using GeekShopping.ProductAPI;

var builder = WebApplication.CreateBuilder(args);

var startup = new Startup(builder.Configuration);

startup.ConfigureServices(builder.Services);


// Add services to the container.

//var connection = Configuration["MySQLConnection:MySQLConnectionString"];

/*builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();*/

var app = builder.Build();

startup.Configure(app, app.Environment);

// Configure the HTTP request pipeline.
/*if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();*/

app.Run();
