namespace Clickxys.Models
{
    public class MachineInfo : IncomeSource
    {
        public MachineInfo() : base() { }
        public int Id { get; set; }
        public override decimal InitialPrice { get; set; } = 1024;
        public override double PriceIncreaseRate { get; set; } = 1.5;
        public override decimal BaseIncome { get; set; } = 100;
    }
}
