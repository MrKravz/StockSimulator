namespace Assets.Scripts.News
{
    public class Subject
    {
        public int CompanyKey { get; set; } = default;
        public Company Company { get; set; } = default;
        public Headline Headline { get; set; } = default;
        public Subject(Company company, Headline headline)
        {
            Company = company;
            Headline = headline;
        }
    }
}
