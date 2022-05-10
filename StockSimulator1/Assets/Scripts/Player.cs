    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public class Player
    {
        public MoneyComponent MoneyComponent { get; private set; } = default;
        public Dictionary<int,Company> Companies { get; } = new Dictionary<int, Company>();
        public Player(MoneyComponent moneyComponent)
        {
            MoneyComponent = moneyComponent;
        }
    }
}
