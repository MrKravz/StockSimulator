using System;

namespace Assets.Scripts
{
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
