namespace Assets.Scripts
{
    class StockManager
    {
        public void BuyStock(int companyKey, Company company , Player player)
        {
            if (player.Companies.ContainsKey(companyKey) || player.MoneyComponent.CurrentMoney < company.PriceComponent.CurrentPrice)
            {
                return;
            }
            player.Companies.Add(companyKey,company);
            new MoneyManager().BuyStockExpanses(player, company);
        }
        public void SellStock(int companyKey, Company company, Player player)
        {
            if (player.Companies.ContainsKey(companyKey))
            {
                player.Companies.Remove(companyKey);
                new MoneyManager().SellStockExpanses(player, company);
                return;
            }
        }
    }
}
