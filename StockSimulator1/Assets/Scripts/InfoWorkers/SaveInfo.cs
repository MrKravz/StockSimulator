using System.Collections.Generic;
using System.IO;
using Assets.Scripts;
using Assets.Scripts.Serializers;

public class SaveInfo 
{
    public void SaveModel(GameplayModel gameplayModel)
    {
        SaveCompaniesInfo(gameplayModel.Companies);
        SavePlayerInfo(gameplayModel.Player);
        SaveStageInfo(gameplayModel.CurrentStage);
    }
   public void SaveCompaniesInfo(Dictionary<int, Company> company)
    {
        ConfigSerializer<Company> configSerializer = new ConfigSerializer<Company>();
        if (File.Exists("D:\\StockSimulator\\SavedGameCompany.json"))
        {
            configSerializer.WtiteDictionary("D:\\StockSimulator\\SavedGameCompany.json", company);
            return;
        }
        File.Create("D:\\StockSimulator\\SavedGameCompany.json").Close();
        configSerializer.WtiteDictionary("D:\\StockSimulator\\SavedGameCompany.json", company);
    }
    public void SavePlayerInfo(Player player)
    {
        ConfigSerializer<Player> configSerializer = new ConfigSerializer<Player>();
        if (File.Exists("D:\\StockSimulator\\SavedGamePlayer.json"))
        {
            configSerializer.WriteObject("D:\\StockSimulator\\SavedGamePlayer.json", player);
            return;
        }
        File.Create("D:\\StockSimulator\\SavedGamePlayer.json").Close();
        configSerializer.WriteObject("D:\\StockSimulator\\SavedGamePlayer.json", player);
    }
    public void SaveStageInfo(EStage stage)
    {
        ConfigSerializer<EStage> configSerializer = new ConfigSerializer<EStage>();
        if (File.Exists("D:\\StockSimulator\\SavedGameStage.json"))
        {
            configSerializer.WriteObject("D:\\StockSimulator\\SavedGameStage.json", stage);
            return;
        }
        File.Create("D:\\StockSimulator\\SavedGameStage.json").Close();
        configSerializer.WriteObject("D:\\StockSimulator\\SavedGameStage.json", stage);
    }

}
