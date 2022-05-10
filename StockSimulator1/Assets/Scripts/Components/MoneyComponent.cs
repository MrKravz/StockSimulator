namespace Assets.Scripts
{
    public class MoneyComponent
    {
        public int CurrentMoney { get; private set; } = default;
        public int StartMoney { get; private set; } = default;
        public MoneyComponent(int currentMoney, int startMoney)
        {
            CurrentMoney = currentMoney;
            StartMoney = startMoney;
        }
        public void Reduce(int reduceValue)
        {
            CurrentMoney -= reduceValue;
        }
        public void Add(int addValue)
        {
            CurrentMoney += addValue;
        }
        public void Reset()
        {
            CurrentMoney = StartMoney;
        }
    }
}
