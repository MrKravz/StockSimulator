using System.Collections.Generic;
using System.IO;
using Assets.Scripts.GameplayComponents;
using Assets.Scripts.GameplayComponents.NewsComponents;
using Assets.Scripts.Serializers;
using UnityEngine;

namespace Assets.Scripts.InfoWorkers
{
    public class SaveInfo
    {
        public void SaveModel(GameplayModel gameplayModel)
        {

            ConfigSerializer<GameplayModel> configSerializer = new ConfigSerializer<GameplayModel>();
            if (File.Exists(Application.dataPath + "\\GameFiles\\SavedGameModel.json"))
            {
                configSerializer.WriteObject(Application.dataPath + "\\GameFiles\\SavedGameModel.json", gameplayModel);
                return;
            }
            File.Create(Application.dataPath + "\\GameFiles\\SavedGameModel.json").Close();
            configSerializer.WriteObject(Application.dataPath + "\\GameFiles\\SavedGameModel.json", gameplayModel);
        }
        public void GenerateHeadlineInfo(List<Headline> headlines)
        {
            ConfigSerializer<Headline> configSerializer = new ConfigSerializer<Headline>();
            if (File.Exists(Application.dataPath + "\\GameFiles\\HeadlineConfig.json"))
            {
                configSerializer.WriteList(Application.dataPath + "\\GameFiles\\HeadlineConfig.json", headlines);
                return;
            }
            File.Create(Application.dataPath + "\\GameFiles\\HeadlineConfig.json").Close();
            configSerializer.WriteList(Application.dataPath + "\\GameFiles\\HeadlineConfig.json", headlines);
        }
        public void GenerateCompaniesInfo(Dictionary<int, Company> companies)
        {
            ConfigSerializer<Company> configSerializer = new ConfigSerializer<Company>();
            if (File.Exists(Application.dataPath + "\\GameFiles\\HeadlineConfig.json"))
            {
                configSerializer.WriteDictionary(Application.dataPath + "\\GameFiles\\CompanyConfig.json", companies);
                return;
            }
            File.Create(Application.dataPath + "\\GameFiles\\CompanyConfig.json").Close();
            configSerializer.WriteDictionary(Application.dataPath + "\\GameFiles\\CompanyConfig.json", companies);
        }
        public void GenerateOcassionsInfo(List<FriendOcassion> ocassions)
        {
            ConfigSerializer<FriendOcassion> configSerializer = new ConfigSerializer<FriendOcassion>();
            if (File.Exists(Application.dataPath + "\\GameFiles\\OcassionsConfig.json"))
            {
                configSerializer.WriteList(Application.dataPath + "\\GameFiles\\OcassionsConfig.json", ocassions);
                return;
            }
            File.Create(Application.dataPath + "\\GameFiles\\OcassionsConfig.json").Close();
            configSerializer.WriteList(Application.dataPath + "\\GameFiles\\OcassionsConfig.json", ocassions);
        }
        public void RemoveAllSavedInfo()
        {
            if (File.Exists(Application.dataPath + "\\GameFiles\\SavedGameModel.json"))
            {
                File.Delete(Application.dataPath + "\\GameFiles\\SavedGameModel.json");
            }
        }
    }
}
