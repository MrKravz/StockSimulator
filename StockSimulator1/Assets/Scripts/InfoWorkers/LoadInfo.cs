using Assets.Scripts.Manager;
using Assets.Scripts.News;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Assets.Scripts
{
    public class LoadInfo
    {
        public GameplayModel LoadModel()
        {
            ConfigDeserialaizer<GameplayModel> configDeserialaizer = new ConfigDeserialaizer<GameplayModel>();
            if (File.Exists(Application.dataPath + "\\GameFiles\\SavedGameModel.json"))
            {
                return configDeserialaizer.GetObject(Application.dataPath + "\\GameFiles\\SavedGameModel.json");
            }
            return new GameplayModel(new Player(new MoneyComponent(1000, 1000)), new ConfigDeserialaizer<Company>().GetDictionary(Application.dataPath + "\\GameFiles\\CompanyConfig.json"), EStage.Primary, default);
        }
      
        public List<Headline> LoadHeadlineInfo()
        {
            List<Headline> headlines = new List<Headline>();
            ConfigDeserialaizer<Headline> configDeserialaizer = new ConfigDeserialaizer<Headline>();
            foreach (var headline in configDeserialaizer.GetList(Application.dataPath + "\\GameFiles\\HeadlineConfig.json"))
            {
                headlines.Add(headline);
            }
            return headlines;
        }
    }
}
