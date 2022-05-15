using Assets.Scripts.News;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Assets.Scripts.Manager
{
    public class CompanyPriceManager
    {
        public CompanyPriceManager()
        {
        }
        public void PerformPriceChanges(GameplayModel gameplayModel)
        {
            Company company;
            int key;
            int a;
            foreach (var item in gameplayModel.Newspaper.Subjects)
            {
                if (item.Headline.Percent > 0)
                {
                    company = gameplayModel.Companies.First(x => x.Key == item.CompanyKey).Value;
                    key = gameplayModel.Companies.First(x => x.Value == company).Key;
                   
                    if (gameplayModel.Player.Companies.ContainsKey(key))
                    {
                        a = company.PriceComponent.CurrentPrice;
                        gameplayModel.Player.Companies.First(x => x.Key == key).Value.PriceComponent.Add(a * item.Headline.Percent / 100);
                    }
                    a = company.PriceComponent.CurrentPrice;
                    company.PriceComponent.Add(a * item.Headline.Percent / 100);
                }
                else
                {
                    company = gameplayModel.Companies.First(x => x.Key == item.CompanyKey).Value;
                    key = gameplayModel.Companies.First(x => x.Value == company).Key;
                    if (gameplayModel.Player.Companies.ContainsKey(key))
                    {
                        a = company.PriceComponent.CurrentPrice;
                        gameplayModel.Player.Companies.First(x => x.Key == key).Value.PriceComponent.Reduce(a * item.Headline.Percent / 100 * -1);
                    }
                    a = company.PriceComponent.CurrentPrice;
                    company.PriceComponent.Reduce(a * item.Headline.Percent / 100 * -1);
                }

            }
        }
    }
}
