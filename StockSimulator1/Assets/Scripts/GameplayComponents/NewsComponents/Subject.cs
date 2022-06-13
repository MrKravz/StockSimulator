using System;

namespace Assets.Scripts.GameplayComponents.NewsComponents
{
    [Serializable]
    public class Subject
    {
        public int CompanyKey { get; set; } = default;
        public Company Company { get; set; } = default;
        public Headline Headline { get; set; } = default;
        public Subject(int companyKey, Company company, Headline headline)
        {
            CompanyKey = companyKey;
            Company = company;
            Headline = headline;
        }
    }
}
