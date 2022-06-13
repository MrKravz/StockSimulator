using Assets.Scripts.Components;
using Assets.Scripts.GameplayComponents;
using Assets.Scripts.GameplayComponents.Managers;
using Assets.Scripts.GameplayComponents.NewsComponents;
using Assets.Scripts.Serializers;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Assets.Scripts.InfoWorkers
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
            return new GameplayModel(new Player(new MoneyComponent(1000, 1000)), new ConfigDeserialaizer<Company>().GetDictionary(Application.dataPath + "\\GameFiles\\CompanyConfig.json"), EStage.Primary, default, default);
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
        public List<FriendOcassion> LoadOcassionInfo()
        {
            List<FriendOcassion> ocassions = new List<FriendOcassion>();
            ConfigDeserialaizer<FriendOcassion> configDeserialaizer = new ConfigDeserialaizer<FriendOcassion>();
            foreach (var ocassion in configDeserialaizer.GetList(Application.dataPath + "\\GameFiles\\OcassionsConfig.json"))
            {
                ocassions.Add(ocassion);
            }
            return ocassions;
        }
    }
}
