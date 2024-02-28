namespace Clickxys.Models
{
    public class ClickInfo : IncomeSource
    {
        public ClickInfo() : base() { Level = 1; }
        public int Id { get; set; }
        public override decimal InitialPrice { get; set; } = 100;
        public override decimal Multiplier { get; set; } = 1;
        public override decimal Price { get; set; }
        public override double PriceIncreaseRate { get; set; } = 1.6;
    }
}
