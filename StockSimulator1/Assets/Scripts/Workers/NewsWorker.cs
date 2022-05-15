using Assets.Scripts;
using Assets.Scripts.News;
using System.Collections.Generic;

public class NewsWorker
{
    public Newspaper GetNews(Dictionary<int, Company> companies, List<Headline> headlines)
    {
        List<Subject> subjects = new List<Subject>(5);
        SubjectGenerator subjectGenerator = new SubjectGenerator();
        foreach (var subject in subjects)
        {
            subjects.Add(subjectGenerator.GetSubject(companies, headlines));
        }
        return new Newspaper(subjects);
    }
}
