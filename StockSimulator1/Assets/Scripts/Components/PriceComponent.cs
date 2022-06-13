using System;

namespace Assets.Scripts.Components
{
    [Serializable]
    public class PriceComponent
    {
        public int StartPrice { get; private set; } = default;
        public int CurrentPrice { get; private set; } = default;
        public PriceComponent(int currentPrice, int startPrice)
        {
            CurrentPrice = currentPrice;
            StartPrice = startPrice;
        }
        public void Reduce(int reduceValue)
        {
            CurrentPrice -= reduceValue;
        }
        public void Add(int addValue)
        {
            CurrentPrice += addValue;
        }
        public void Reset()
        {
            CurrentPrice = StartPrice;
        }
    }
}
