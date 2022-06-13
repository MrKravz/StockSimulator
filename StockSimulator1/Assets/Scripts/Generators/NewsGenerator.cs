using Assets.Scripts.GameplayComponents;
using Assets.Scripts.GameplayComponents.NewsComponents;
using System.Collections.Generic;

namespace Assets.Scripts.Generators
{
    public class NewsGenerator
    {
        public Newspaper GetNews(int value, Dictionary<int, Company> companies, List<Headline> headlines)
        {
            List<Subject> subjects = new List<Subject>();
            SubjectGenerator subjectGenerator = new SubjectGenerator();
            for (int i = 0; i < value; i++)
            {
                subjects.Add(subjectGenerator.GetSubject(companies, headlines));
            }
            return new Newspaper(subjects);
        }
    }
}
