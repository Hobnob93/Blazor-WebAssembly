namespace BlazorBattles.Shared.Models
{
    public class UnitTemplate
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Damage { get; set; }
        public int Defense { get; set; }
        public int Health { get; set; } = 100;
        public int Cost { get; set; }
    }
}
