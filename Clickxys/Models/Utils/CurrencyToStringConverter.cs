namespace Clickxys.Models.Utils
{
    public class CurrencyToStringConverter
    {
        public static string CurrencyToString(decimal value)
        {
            if (value < 1000)
            {
                return value.ToString();
            }
            else if (value < 1000000)
            {
                return (value / 1000.0m).ToString("0.##") + "k";
            }
            else
            {
                return (value / 1000000.0m).ToString("0.##") + "M";
            }
        }
    }
}
