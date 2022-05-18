using System;
using System.Collections.Generic;

namespace Assets.Scripts
{
    [Serializable]
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
