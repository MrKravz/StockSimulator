using Assets.Scripts.Manager;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class GameplayModel

    {
        public Player Player { get; private set; } = default;
        public Dictionary<int,Company> Companies { get; private set; } = default;
        private EStage currentStage;
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
        public GameplayModel(Player player, Dictionary<int, Company> companies, EStage currentStage)
        {
            Player = player;
            Companies = companies;
            CurrentStage = currentStage;
        }
    }
}

