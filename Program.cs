using wt_lab6_6minimalapi_zhiznevskaya.Data;
using wt_lab6_6minimalapi_zhiznevskaya.Models;

var builder = WebApplication.CreateBuilder(args);

// ===== OpenAPI / Swagger =====
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// ===== Swagger UI (включён всегда, чтобы работал на Render) =====
app.UseSwagger();
app.UseSwaggerUI();

// ===== Блок 1 =====
app.MapGet("/", () => "Minimal API работает!");

app.MapGet("/api/info", () =>
{
    return new
    {
        Application = "Web Technologies",
        Technology = "ASP.NET Core Minimal API",
        Version = "1.0"
    };
});

// ===== Блок 3: GET =====
app.MapGet("/api/cars", (string? search) =>
{
    var cars = CarStore.Cars.AsEnumerable();
    if (!string.IsNullOrWhiteSpace(search))
    {
        cars = cars.Where(c => c.Brand.Contains(search, StringComparison.OrdinalIgnoreCase)
                            || c.Model.Contains(search, StringComparison.OrdinalIgnoreCase));
    }
    return Results.Ok(cars);
});

app.MapGet("/api/cars/{id}", (int id) =>
{
    var car = CarStore.Cars.FirstOrDefault(c => c.Id == id);
    if (car == null) return Results.NotFound();
    return Results.Ok(car);
});

// ===== Блок 4: POST =====
app.MapPost("/api/cars", (Car car) =>
{
    car.Id = CarStore.Cars.Count == 0 ? 1 : CarStore.Cars.Max(c => c.Id) + 1;
    CarStore.Cars.Add(car);
    return Results.Created($"/api/cars/{car.Id}", car);
});

// ===== Блок 5: PUT + DELETE =====
app.MapPut("/api/cars/{id}", (int id, Car updatedCar) =>
{
    var car = CarStore.Cars.FirstOrDefault(c => c.Id == id);
    if (car == null) return Results.NotFound();

    car.Brand = updatedCar.Brand;
    car.Model = updatedCar.Model;
    car.Year = updatedCar.Year;
    car.PricePerDay = updatedCar.PricePerDay;
    car.IsAvailable = updatedCar.IsAvailable;

    return Results.Ok(car);
});

app.MapDelete("/api/cars/{id}", (int id) =>
{
    var car = CarStore.Cars.FirstOrDefault(c => c.Id == id);
    if (car == null) return Results.NotFound();

    CarStore.Cars.Remove(car);
    return Results.NoContent();
});

app.Run();