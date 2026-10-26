using wt_lab6_6minimalapi_zhiznevskaya.Models;

namespace wt_lab6_6minimalapi_zhiznevskaya.Data;

public static class CarStore
{
    public static List<Car> Cars { get; } = new()
    {
        new Car { Id = 1, Brand = "Toyota", Model = "Camry", Year = 2022, PricePerDay = 5000, IsAvailable = true },
        new Car { Id = 2, Brand = "BMW", Model = "X5", Year = 2023, PricePerDay = 12000, IsAvailable = true },
        new Car { Id = 3, Brand = "Volvo", Model = "FH16", Year = 2021, PricePerDay = 18000, IsAvailable = false },
        new Car { Id = 4, Brand = "Kia", Model = "Rio", Year = 2021, PricePerDay = 3500, IsAvailable = true },
        new Car { Id = 5, Brand = "Mercedes-Benz", Model = "GLE", Year = 2024, PricePerDay = 15000, IsAvailable = true },
    };
}