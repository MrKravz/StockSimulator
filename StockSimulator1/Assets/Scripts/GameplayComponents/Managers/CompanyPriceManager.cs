using System.Linq;

namespace Assets.Scripts.Manager
{
    public class CompanyPriceManager
    {
        public CompanyPriceManager() { }
        public void PerformPriceChanges(GameplayModel gameplayModel)
        {
            Company company;
            int key;
            foreach (var item in gameplayModel.Newspaper.Subjects)
            {
                if (item.Headline.Percent > 0)
                {
                    company = gameplayModel.Companies.First(x => x.Key == item.CompanyKey).Value;
                    key = gameplayModel.Companies.First(x => x.Value == company).Key;
                    if (gameplayModel.Player.Companies.ContainsKey(key))
                    {
                        gameplayModel.Player.Companies.First(x => x.Key == key).Value.PriceComponent.Add(company.PriceComponent.CurrentPrice * item.Headline.Percent / 100);
                    }
                    company.PriceComponent.Add(company.PriceComponent.CurrentPrice * item.Headline.Percent / 100);
                }
                else
                {
                    company = gameplayModel.Companies.First(x => x.Key == item.CompanyKey).Value;
                    key = gameplayModel.Companies.First(x => x.Value == company).Key;
                    if (gameplayModel.Player.Companies.ContainsKey(key))
                    {
                        gameplayModel.Player.Companies.First(x => x.Key == key).Value.PriceComponent.Reduce(company.PriceComponent.CurrentPrice * item.Headline.Percent / 100 * -1);
                    }
                    company.PriceComponent.Reduce(company.PriceComponent.CurrentPrice * item.Headline.Percent / 100 * -1);
                }

            }
        }
    }
}
