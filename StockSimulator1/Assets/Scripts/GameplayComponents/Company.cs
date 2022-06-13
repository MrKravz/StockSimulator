using Assets.Scripts.Components;
using System;

namespace Assets.Scripts.GameplayComponents
{
    public enum ETypeOfCompany
    {
        Logistic = 1,
        Food = 2,
        IT = 3,
        Clothes = 4,
        Medicine = 5,
        Inventions = 6,
        Movies = 7
    }
    [Serializable]
    public class Company
    {
        public string Name { get; private set; } = default;
        public ETypeOfCompany Type { get; private set; } = default;
        public PriceComponent PriceComponent { get; private set; } = default;
        public Company(string name, ETypeOfCompany type, PriceComponent priceComponent)
        {
            Name = name;
            Type = type;
            PriceComponent = priceComponent;
        }
    }
}
