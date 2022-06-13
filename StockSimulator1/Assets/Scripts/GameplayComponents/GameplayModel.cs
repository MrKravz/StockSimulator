using Assets.Scripts.GameplayComponents.Managers;
using Assets.Scripts.GameplayComponents.NewsComponents;
using System;
using System.Collections.Generic;

namespace Assets.Scripts.GameplayComponents
{
    [Serializable]
    public class GameplayModel
    {
        public Player Player { get; private set; } = default;
        public Dictionary<int,Company> Companies { get; private set; } = default;
        private EStage currentStage;
        public Newspaper Newspaper { get; set; } = default;
        public FriendOcassion Ocassion { get; set; } = default;
        public EStage CurrentStage { get; set; } = default;
        public GameplayModel(Player player, Dictionary<int, Company> companies, EStage currentStage, Newspaper newspaper, FriendOcassion ocassion)
        {
            Player = player;
            Companies = companies;
            CurrentStage = currentStage;
            Newspaper = newspaper;
            Ocassion = ocassion;
        }
    }
}

