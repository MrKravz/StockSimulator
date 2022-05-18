using Assets.Scripts;
using Assets.Scripts.News;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SubjectGenerator
{
    public Subject GetSubject(Dictionary<int, Company> companies, List<Headline> headlines)
    {
        int a = Random.Range(1, companies.Count);
        Company company = companies.First(x => x.Key == a).Value;
        Headline currentHeadline = headlines[Random.Range(0, headlines.Count - 1)];
        return new Subject(a,company, currentHeadline);
    }
}
