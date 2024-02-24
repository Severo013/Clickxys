namespace Clickxys.Models
{
    public abstract class IncomeSource
    {
        public int Level { get; set; }
        public decimal Price { get; set; }
        public decimal Income { get; set; }
        public decimal Multiplier { get; set; }
    }
}
