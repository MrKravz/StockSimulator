namespace Assets.Scripts
{
    public enum ETypeOfCompany
    {
        Logistic = 1,
        Food = 2,
        IT = 3,
        Clothes = 4,
        Medicine = 5,
        SpaceInventions = 6,
        Movies = 7
    }
    public class TypedHeadline : Headline
    {
        public ETypeOfCompany Type { get; set; } = default;
        public TypedHeadline(string text, int percent, ETypeOfCompany typeOfCompany) : base(text, percent)
        {
            Type = typeOfCompany;
        }
    }
}
