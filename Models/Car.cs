namespace wt_lab7_7postgres_efcore_zhiznevskaya.Models;

public class Car
{
    public int Id { get; set; }
    public string Brand { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public int Year { get; set; }
    public decimal PricePerDay { get; set; }
    public bool IsAvailable { get; set; } = true;
    
    // Новое свойство
    public DateTime CreatedAt { get; set; }
}