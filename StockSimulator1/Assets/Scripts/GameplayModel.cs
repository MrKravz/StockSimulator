using Assets.Scripts.Manager;
using System.Collections.Generic;

namespace Assets.Scripts
{
    public class GameplayModel

    {
        public Player Player { get; private set; } = default;
        public Dictionary<int,Company> Companies { get; private set; } = default;
        private EStage currentStage = default;
        public EStage CurrentStage
        {
            get
            {
                return currentStage;
            }
            set
            {
                currentStage = value;
                new StageManager().OnStageSwitch.Invoke();
            }
        } 
        public GameplayModel(Player player, Dictionary<int, Company> companies, EStage currentStage)
        {
            Player = player;
            Companies = companies;
            CurrentStage = currentStage;
        }
    }
}

