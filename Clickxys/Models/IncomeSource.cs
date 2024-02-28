namespace Clickxys.Models
{
    public abstract class IncomeSource
    {
        public IncomeSource()
        {
            Price = InitialPrice;
        }

        public int Level { get; set; }
        public virtual decimal Price { get; set; }
        public virtual decimal CurrentIncome { get; set; }
        public virtual decimal BaseIncome { get; set; }
        public virtual decimal Multiplier { get; set; }
        public virtual decimal InitialPrice { get; set; }
        public virtual double PriceIncreaseRate { get; set; }

        public virtual void IncreaseLevel(int value = 1)
        {
            Level += value;
            CurrentIncome += BaseIncome;
        }

        public virtual void IncreaseMultiplier(int value = 1)
        {
            Multiplier += value;
        }

        public virtual void UpdatePrice()
        {
            Price *= (decimal)Math.Pow(PriceIncreaseRate, Level);
        }
    }
}
