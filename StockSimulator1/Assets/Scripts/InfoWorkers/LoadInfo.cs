using Assets.Scripts.News;
using System.Collections.Generic;
using System.IO;

namespace Assets.Scripts
{
    public class LoadInfo
    {
        public GameplayModel LoadModel()
        {
            return new GameplayModel(LoadPlayerInfo(), LoadCompaniesInfo(), LoadStageInfo(),LoadNewsInfo());
        }
        public Dictionary<int,Company> LoadCompaniesInfo()
        {
            ConfigDeserialaizer<Company> configDeserialaizer = new ConfigDeserialaizer<Company>();
            if (File.Exists("D:\\StockSimulator\\SavedGameCompany.json"))
            {
                return configDeserialaizer.GetDictionary("D:\\StockSimulator\\SavedGameCompany.json");
            }
            return configDeserialaizer.GetDictionary("D:\\StockSimulator\\CompanyConfig.json");
        }
        public List<Headline> LoadHeadlineInfo()
        {
            List<Headline> headlines = new List<Headline>();
            ConfigDeserialaizer<Headline> configDeserialaizer = new ConfigDeserialaizer<Headline>();
            foreach (var headline in configDeserialaizer.GetList("D:\\StockSimulator\\HeadlineConfig.json"))
            {
                headlines.Add(headline);
            }
            return headlines;
        }
        public Player LoadPlayerInfo()
        {
            if (File.Exists("D:\\StockSimulator\\SavedGamePlayer.json"))
            {
                ConfigDeserialaizer<Player> configDeserialaizer = new ConfigDeserialaizer<Player>();
                return configDeserialaizer.GetObject("D:\\StockSimulator\\SavedGamePlayer.json");
            }
            return new Player(new MoneyComponent(1000,1000));
        }
        public Newspaper LoadNewsInfo()
        {
            if (File.Exists("D:\\StockSimulator\\SavedGameNewspaper.json"))
            {
                ConfigDeserialaizer<Newspaper> configDeserialaizer = new ConfigDeserialaizer<Newspaper>();
                return configDeserialaizer.GetObject("D:\\StockSimulator\\SavedGameNewspaper.json");
            }
            return default;
        }
        public EStage LoadStageInfo()
        {
            if (File.Exists("D:\\StockSimulator\\SavedGameStage.json"))
            {
                ConfigDeserialaizer<EStage> configDeserialaizer = new ConfigDeserialaizer<EStage>();
                return configDeserialaizer.GetObject("D:\\StockSimulator\\SavedGameStage.json");
            }
            return EStage.Primary;
        }
    }
}
