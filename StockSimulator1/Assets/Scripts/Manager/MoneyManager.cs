namespace Assets.Scripts
{
   public class MoneyManager
    {
        public void BuyStockExpanses(Player player, Company company)
        {
            player.MoneyComponent.Reduce(company.PriceComponent.CurrentPrice);
        }
        public void SellStockExpanses(Player player, Company company)
        {
            player.MoneyComponent.Add(company.PriceComponent.CurrentPrice);
        }
        public void DailyExpenses(Player player)
        {
            player.MoneyComponent.Reduce(125);
        }
        public void StocksProfit(Player player)
        {
            foreach (var item in player.Companies)
            {
                player.MoneyComponent.Add(item.Value.PriceComponent.CurrentPrice / 100 * 30);
            }
        }
    }
}
