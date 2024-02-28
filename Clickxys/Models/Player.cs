
namespace Clickxys.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public string Photourl { get; set; }
        public string Country { get; set; }
        public DateTime LastTimeOnline { get; set; }
        public MachineInfo Machines { get; set; } = new();
        public ClickInfo ClickInfo { get; set; } = new();
        public CurrencyInfo Currency { get; set; } = new();
    }
}
