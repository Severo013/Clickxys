namespace Clickxys.Models
{
    public class CurrencyInfo
    {
        public int Id { get; set; }
        public decimal CurrentBalance { get; set; }
        public decimal PassiveIncome { get; set; }
        public decimal HourlyIncome => PassiveIncome * 60 * 60;
    }
}
