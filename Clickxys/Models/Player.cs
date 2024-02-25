
namespace Clickxys.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public string Photourl { get; set; }
        public string Country { get; set; }
        public DateTime LastTimeOnlyne { get; set; }
        public MachineInfo Machines { get; set; }
        public ClickInfo ClickInfo { get; set; }
        public CurrencyInfo Currency { get; set; }
    }
}
