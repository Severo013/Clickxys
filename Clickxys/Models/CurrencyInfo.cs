namespace Clickxys.Models
{
    public class CurrencyInfo
    {
        public int Id { get; set; }
        public decimal CurrentBalance { get; set; }
        public decimal PassiveIncome { get; set; }
        public decimal HourlyIncome => PassiveIncome * 60 * 60;

        public void DecreaseBalance(decimal value)
        {
            CurrentBalance -= value;
        }
        
        public void SetBalance(decimal value)
        {
            CurrentBalance = value;
        }

        public void IncreasePassiveIncome(decimal value)
        {
            PassiveIncome += value;
        }
    }
}
