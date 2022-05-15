using Assets.Scripts.News;
using System.Collections.Generic;

namespace Assets.Scripts
{
    public class GameplayModel

    {
        public Player Player { get; private set; } = default;
        public Dictionary<int,Company> Companies { get; private set; } = default;
        private EStage currentStage;
        public Newspaper Newspaper { get; set; } = default;
        public EStage CurrentStage
        {
            get
            {
                return currentStage;
            }
            set
            {
                currentStage = value;
            }
        } 
        public GameplayModel(Player player, Dictionary<int, Company> companies, EStage currentStage, Newspaper newspaper)
        {
            Player = player;
            Companies = companies;
            CurrentStage = currentStage;
            Newspaper = newspaper;
        }
    }
}

