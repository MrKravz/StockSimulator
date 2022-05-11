using System.Collections.Generic;
using System.IO;

namespace Assets.Scripts
{
    public class LoadInfo
    {
        public GameplayModel LoadModel()
        {
            return new GameplayModel(LoadPlayerInfo(), LoadCompaniesInfo(), LoadStageInfo());
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
            ConfigDeserialaizer<DefaultHeadline> configDeserialaizer = new ConfigDeserialaizer<DefaultHeadline>();
            foreach (var headline in configDeserialaizer.GetList("D:\\StockSimulator\\DefaultZagConfig.json"))
            {
                headlines.Add(headline);
            }
            foreach (var headline in configDeserialaizer.GetList("D:\\StockSimulator\\TypedZagConfig.json"))
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
        public EStage LoadStageInfo()
        {
            if (File.Exists("D:\\StockSimulator\\SavedGameStage.json"))
            {
                ConfigDeserialaizer<EStage> configDeserialaizer = new ConfigDeserialaizer<EStage>();
                return configDeserialaizer.GetObject("D:\\StockSimulator\\SavedGameStage.json");
            }
            return EStage.Renew;
        }
    }
}
