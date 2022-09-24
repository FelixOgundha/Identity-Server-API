namespace API.Models
{
    public class CoffeeShopModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string OpeningHours { get; set; } = string.Empty;
        public string Address { get; set; } =string.Empty;
    }
}
